using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Services;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItService _ReverseITService;

        public ReverseItController(ReverseItService reverseItService)
        {
            _ReverseITService = reverseItService;
        }

        [HttpPost]
        [Route("ReverseIt/{userInput}")]
        public string ReverseIt(string userInput){
            return _ReverseITService.ReverseString(userInput);
        }
    }
}