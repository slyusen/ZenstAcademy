using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZenstAcademy.Controllers
{
    [Route("/api/home")]
    public class HomeController : Controller
    {
        // GET api/values
       
        [HttpGet]
        public IActionResult Greetings() {
            return Ok("Great it works. Changed");
        }
    }
}
