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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _MadLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _MadLibServices = madLibServices;
        }

        [HttpPost]
        [Route("MadLib/{monster},{monsterAdjec},{noun1},{noun2},{object1},{object2},{location},{location2},{userName},{userNameAdjec}")]
        public string MadLibPost(string monster, string monsterAdjec, string noun1, string noun2, string object1, string object2, string location, string location2, string userName, string userNameAdjec)
        {
            return _MadLibServices.MadLibMethod(monster, monsterAdjec, noun1, noun2, object1, object2, location, location2,userName, userNameAdjec);
        }
    }
}