using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            // return a ViewResult object
            return View();
        }

        public IActionResult Info()
        {
            return Content("Hello from the comic book store.");
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
