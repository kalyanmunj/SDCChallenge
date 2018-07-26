using System;
using Xunit;
using Moq;
using System.Threading.Tasks;
using SDCChallenge.Controllers;
using SDCChallenge.Services;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace SDCChallengeTest
{
    
    public class LaunchpadTest
    {
        [Fact]
        public void Get_returns_LaunchPadDetails()
        {
            var moqRepo = new Mock<ISpacexService>();
            moqRepo.Setup(x => x.GetLaunchPadDetails(It.IsAny<string>())).Returns(new System.Collections.Generic.List<SDCChallenge.Models.LaunchPadDetails>() { new SDCChallenge.Models.LaunchPadDetails {  LaunchPadID ="12" , LaunchPadName="ABC" , LaunchPadStatus="active"} });
            var controller = new LaunchpadController(moqRepo.Object);

            var  result = controller.Get("2") as OkObjectResult;

            Assert.Equal(200, result.StatusCode);
            

            
        }
    }
}
