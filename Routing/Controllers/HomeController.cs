using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.Models;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //pass details to the DetailView through  ViewBag.Data (data doesn't mean anything)
        //can the pattern in endpoints.mapcontrollerroute be a variable??

    /*    public IActionResult WebsiteOne([FromQuery] string myQuery) {
            return View("DetailView");
    }

        public IActionResult WebsiteTwo([FromQuery] string myQuery)
        {
            return View("DetailView");
        }

        public IActionResult WebsiteThree([FromQuery] string myQuery)
        {
            return View("DetailView");
        }*/


 /*       public IActionResult GenericQueryRoute(string pattern, [FromQuery] string query)
        {
            return View("DetailView");
        }*/

        public IActionResult GenericRoute(string stringOne, string stringTwo, string stringThree, string stringFour, string stringFive, string stringSix)
        {
            return View("DetailView");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
