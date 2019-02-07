using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task4.Models;
using HtmlAgilityPack;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        public IParser parser;
        public HomeController(IParser parser)
        {
            this.parser = parser;
        }
        public async Task<IActionResult> Index()
        {   
                 
            return View(await parser.GetStringDoc());
        }
        [HttpPost]
        // public IActionResult Index(string searchInput) {
        //     return View(parser.GetStringDoc(searchInput));
        // }
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
