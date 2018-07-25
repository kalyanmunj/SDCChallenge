using System;
using System.Collections.Generic;
using System.Text;
using SDCChallenge.Models;

namespace SDCChallenge.Services
{
    public interface ISpacexService
    {
        LaunchPadDetails GetLaunchPadDetails(string Id);
    }
}
