using System;
using System.Collections.Generic;
using SDCChallenge.Models;
using SDCChallenge.Services.Gateways;
using System.Linq;
namespace SDCChallenge.Services
{
    public class SpaceXService : ISpacexService
    {

        

        public List<LaunchPadDetails> GetLaunchPadDetails(string Id)
        {
            //TODO: Call api gateway 
            SpacexGateway gateway = new SpacexGateway();
            return gateway.GetLaunchpadDetails(Id).Result;
            //returning new instance for testing
            //return new LaunchPadDetails { LaunchPadID="1", LaunchPadName ="SomeName", LaunchPadStatus ="ready" };
            //throw new NotImplementedException();
        }

        public List<LaunchPadDetails> GetLaunchPadDetails(LaunchPadDetails launchPadDetails)
        {
            //TODO: Call api gateway 
            SpacexGateway gateway = new SpacexGateway();
            var launchPadDetailsList = gateway.GetLaunchpadDetails(launchPadDetails.LaunchPadID).Result;
            return launchPadDetailsList.Where(x => x.LaunchPadID == launchPadDetails.LaunchPadID || x.LaunchPadName == launchPadDetails.LaunchPadName || x.LaunchPadStatus == launchPadDetails.LaunchPadStatus).ToList();
            
        }

    }
}
