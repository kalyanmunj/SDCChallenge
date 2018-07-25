using System;
using SDCChallenge.Models;
using SDCChallenge.Services.Gateways;

namespace SDCChallenge.Services
{
    public class SpaceXService : ISpacexService
    {

        

        public LaunchPadDetails GetLaunchPadDetails(string Id)
        {
            //TODO: Call api gateway 
            SpacexGateway gateway = new SpacexGateway();
            return gateway.GetLaunchpadDetails(Id).Result;
            //returning new instance for testing
            //return new LaunchPadDetails { LaunchPadID="1", LaunchPadName ="SomeName", LaunchPadStatus ="ready" };
            //throw new NotImplementedException();
        }
    }
}
