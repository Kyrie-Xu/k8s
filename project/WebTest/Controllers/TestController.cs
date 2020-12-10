using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class TestController: Controller
    {
        private readonly MyDBContext myDBContext;

        public TestController(MyDBContext myDBContext)
        {
            this.myDBContext = myDBContext;
        }

        [HttpGet]
        [Route("users")]
        [Produces("application/json")]
        public IActionResult GetUser()
        {
            return Json(myDBContext.Users.OrderByDescending(i => i.Id).Take(10).ToList(), new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
    }
}
