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
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        private readonly ReverseItNumbersOnlyService _ReverseItNumbersOnlyService;
        public ReverseItNumbersOnlyController(ReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
            _ReverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }

        [HttpPost]
        [Route("ReverseNumbers/{number}")]
        public string ReverseNumber(string number)
        {
            return _ReverseItNumbersOnlyService.ReverseInteger(number);
        }
    }
}