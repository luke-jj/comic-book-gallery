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
        public IActionResult Details()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday) {
                return Redirect("/");
            }

            return Content("Hello from the comic book store.");
        }
    }
}
