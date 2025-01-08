using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Services;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _OddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _OddOrEvenService = oddOrEvenService;
        }

        [HttpPost]
        [Route("OddOrEven/{number}")]
        public string OddOrEven(string number)
        {
            return _OddOrEvenService.OddOrEvenMethod(number);
        }
    }
}