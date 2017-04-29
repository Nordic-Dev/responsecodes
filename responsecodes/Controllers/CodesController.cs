using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace responsecodes.Controllers
{
    public class CodesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Four()
        {
            return BadRequest("Bad request, yo!");
        }

        public IActionResult Two()
        {
            return new OkResult();
        }

        public IActionResult Five()
        {
            return StatusCode(500, "Big failure!");
        }


    }
}