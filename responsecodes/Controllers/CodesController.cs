using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace responsecodes.Controllers
{
    public class CodesController : Controller
    {
        public IActionResult Four()
        {
            return BadRequest("Bad request, yo!");
        }

        public IActionResult Two()
        {
            return new CreatedResult("/here", "wellDone");
        }

        public IActionResult Five()
        {
            return StatusCode(500, "Big failure!");
        }


    }
}