using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SDCChallenge.Services;
using SDCChallenge.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SDCChallenge.Controllers
{
    [Route("api/[controller]")]
    public class LaunchpadController : Controller
    {
        private ISpacexService _spacexService;
        public LaunchpadController(ISpacexService spacexService)
        {
            //dependency inject to make the application plugable to DB 
            _spacexService = spacexService;
        }

        // GET api/<controller>/5
        [HttpGet("{id?}")]
        public IActionResult Get(string id)
        {
            var launchPadDetails = _spacexService.GetLaunchPadDetails(id);
            //if (res != null && res.Count > 0)
                return Ok(launchPadDetails);
            //else return NotFound();
        }
        //[Route("GetLaunchPadDetailsByID")]
        //[HttpGet()]
        //public IActionResult Get(LaunchPadDetails launchPadDetails)
        //{
        //    var result = _spacexService.GetLaunchPadDetails(launchPadDetails);
        //    //if (res != null && res.Count > 0)
        //    return Ok(result);
        //    //else return NotFound();
        //}

    }
}
