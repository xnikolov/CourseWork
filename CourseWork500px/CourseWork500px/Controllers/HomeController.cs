using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseWork500px.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace CourseWork500px.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment he;
        public HomeController (IHostingEnvironment e)
        {
            he = e;
        }

        public IActionResult Index()
        {
            return View();
        }
    /*
        public IActionResult ShowFields(string fullName)
        {
            ViewData["fname"] = fullName;

            return View();
        }
        */

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
                    
            return View();
        }

        public IActionResult Contact(string fullName, IFormFile pic, string description, string keywords)
        {
            if(pic != null)
            {
                var fileName = Path.Combine(he.WebRootPath, Path.GetFileName(pic.FileName));
                pic.CopyTo(new FileStream(fileName, FileMode.Create));

                ViewData["fileLocation"] = fileName;


               
            }


            ViewData["fname"] = fullName;
            ViewData["descr"] = description;
            ViewData["tags"] = keywords;

            return View();
        }

        public IActionResult Gallery(string fullName, IFormFile pic)
        {
            if (pic != null)
            {
                var fileName = Path.Combine(he.WebRootPath, Path.GetFileName(pic.FileName));
                pic.CopyTo(new FileStream(fileName, FileMode.OpenOrCreate));
                ViewData["fileLocation"] = "/"+Path.GetFileName(pic.FileName);
            }

            ViewData["fname"] = fullName;

            return View();
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
