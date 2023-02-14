using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BigChillinContext _privateChillinContext { get; set; }

        public HomeController(ILogger<HomeController> logger, BigChillinContext someName)
        {
            _logger = logger;
            _privateChillinContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Moves()
        {
            return View("movieForm");
        }

        [HttpPost]
        public IActionResult Moves(MovieSubmission ms)
        {
            _privateChillinContext.Add(ms);
            _privateChillinContext.SaveChanges();
            return View("conformation", ms);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
