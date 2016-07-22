using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectName.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(new List<string>(){ "It", "is", "Working"});
        }


    }
}
