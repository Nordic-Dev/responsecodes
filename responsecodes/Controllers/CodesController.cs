using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace responsecodes.Controllers
{
    [Route("/")]
    public class CodesController : Controller
    {
        [Route("400")]
        public IActionResult Four()
        {
            return BadRequest(JsonConvert.SerializeObject("Bad request, yo!"));
        }

        [Route("200")]
        public IActionResult Two()
        {
            return new CreatedResult("/here", JsonConvert.SerializeObject("wellDone"));
        }

        [Route("500")]
        public IActionResult Five()
        {
            return StatusCode(500, JsonConvert.SerializeObject("Big failure!"));
        }


    }
}