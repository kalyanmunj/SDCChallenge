using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SDCChallenge.Models;

//using Microsoft.AspNetCore.JsonPatch indirectly as newtonsoft dosent support .Net core 2.0 directly

namespace SDCChallenge.Services.Gateways
{
    class SpacexGateway
    {
        private Uri _spacexAPI = new Uri("https://api.spacexdata.com/v2/launchpads/");

        HttpClient client = new HttpClient();

        public SpacexGateway()
        {
            client.BaseAddress = _spacexAPI;
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<LaunchPadDetails> GetLaunchpadDetails(string Id)
        {
            SpacexgatewayResponse gatewayResponse = new SpacexgatewayResponse();
            HttpResponseMessage response = await client.GetAsync(Id);
            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                 gatewayResponse =  JsonConvert.DeserializeObject<SpacexgatewayResponse>(result);
                
            }
            //TODO: use auto mmapper
            return new LaunchPadDetails { LaunchPadID = gatewayResponse.id, LaunchPadName = gatewayResponse.full_name, LaunchPadStatus = gatewayResponse.status };
        }
      
    }

    //TODO: need to find an ideal location. This model is used only in the gateway method to deserialize to know type
    class SpacexgatewayResponse
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string status { get; set; }
    }
}
