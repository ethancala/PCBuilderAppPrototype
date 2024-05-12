using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCBuilderPrototype1.Data;
using PCBuilderPrototype1.Models;
using SQLitePCL;
using System.Diagnostics;

namespace PCBuilderPrototype1.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;        }



        [HttpPost]
        public IActionResult SubmitBuild(PCBuild build) {
            using (var db = new ApplicationDbContext())
            {
                db.Add(build);
                db.SaveChanges();
            }
            
            return RedirectToAction("BuildConfirmation");

        }
        public IActionResult SubmitBuild()
        {
            return View("SubmitBuild");
        }



        public IActionResult BuildConfirmation()
        {
            return View();
        }

       

        public IActionResult MyBuilds()
        {
            List<PCBuild> builds = new List<PCBuild>();

            using(var db = new ApplicationDbContext())
            {
                builds = db.PCBuilds.ToList();
            }

            ViewBag.builds = builds;

         
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
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