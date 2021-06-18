using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoreBooks.Models;


namespace CoreBooks.Controllers
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
            var ktp = new List<Books>()
            {
                new Books(){ID=1,BookName="Cheess",Author="Zweig"},
                new Books(){ID=2,BookName="Dr Ox's Experiment",Author="Jules Verne"},
                new Books(){ID=3,BookName="Experiment",Author="VasconCeulos"},
                new Books(){ID=4,BookName="REd Bicycle",Author="Muzaffer İzgü"},
                new Books(){ID=5,BookName="Toros Canavarı",Author="Aziz Nesin"}


            };

            return View(ktp);
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
        public IActionResult Deneme()
        {
            return View();
           
        }
        public IActionResult StaticThema()
        {
            return View();

        }
    }
}
