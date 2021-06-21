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

 

        public IActionResult GenericRoute(string stringOne, string optTwo, string optThree, string optFour, string optFive, string optSix)
        {
           
            ViewBag.Data = stringOne + optTwo + optThree + optFour + optFive + optSix;
            return View("DetailView");
        }


        /*          Request --> goes through Routing --> 
         *   makes instance of the Controller with Query String, Path (piece of the path to each part of the pattern in Startup?), Route Values --> Action()*/
        /*          Route values and query values are both types of dictionaries- so you can iterate through them! */
        /*          URL = protocol://site/path(s)/?querystring*/
        /*          path- can have multiple paths seperated by slashes, but never by unescaped question marks */
        /*          Routing is concerned with the Path part- not the site*/
        public IActionResult Watch()
        {
            /*          it does this below for you automatically- but you can access them here (grab the query here through ViewBag.Query)*/
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;
            Request.

            return View("SharedTemplate");
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
