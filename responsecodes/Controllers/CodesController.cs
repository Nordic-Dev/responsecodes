using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace responsecodes.Controllers
{
    public class CodesController : Controller
    {
        public IActionResult Four()
        {
            return BadRequest(JsonConvert.SerializeObject("Bad request, yo!"));
        }

        public IActionResult Two()
        {
            return new CreatedResult("/here", JsonConvert.SerializeObject("wellDone"));
        }

        public IActionResult Five()
        {
            return StatusCode(500, JsonConvert.SerializeObject("Big failure!"));
        }


    }
}