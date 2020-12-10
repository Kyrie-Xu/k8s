using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HealthController : Controller
    {

        [HttpGet]
        [Route("health")]
        public IActionResult Health()
        {
            return Forbid();
        }
    }
}
