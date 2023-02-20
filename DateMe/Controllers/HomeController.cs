using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;



namespace DateMe.Controllers

{
    public class HomeController : Controller
    {
 
        private BigChillinContext _privateChillinContext { get; set; }

        public HomeController(BigChillinContext someName)
        {
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
            ViewBag.categories = _privateChillinContext.Categories.ToList();
            return View("movieForm");
        }

        [HttpPost]
        public IActionResult Moves(MovieSubmission ms)
        {
            if (ModelState.IsValid)
            {
                _privateChillinContext.Add(ms);
                _privateChillinContext.SaveChanges();
                return View("conformation", ms);
            }
            else
            {
                ViewBag.categories = _privateChillinContext.Categories.ToList();
                return View(ms);
            }
            
        }

        [HttpGet]
        public IActionResult MovieBank()
        {
            var prospectives = _privateChillinContext.Submissions
                .Include(x => x.Category)
                .ToList();

            return View(prospectives);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.categories = _privateChillinContext.Categories.ToList();
            var submission = _privateChillinContext.Submissions.Single(x => x.MovieID == id);

            return View("MovieForm", submission);
        }

        [HttpPost]
        public IActionResult Edit(MovieSubmission elaine)
        {
            _privateChillinContext.Update(elaine);
            _privateChillinContext.SaveChanges();

            return RedirectToAction("MovieBank");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var submission = _privateChillinContext.Submissions.Single(x => x.MovieID == id);
            return View(submission);
        }
        [HttpPost]
        public IActionResult Delete(MovieSubmission ms)
        {
            _privateChillinContext.Submissions.Remove(ms);
            _privateChillinContext.SaveChanges();

            return RedirectToAction("MovieBank");
        }
    }
}
