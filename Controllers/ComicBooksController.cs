using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using comic_book_gallery.Models;
using comic_book_gallery.Data;

namespace comic_book_gallery
{
    public class ComicBooksController : Controller
    {
        /*
         * This data is referenced from `/Data/ComicBookRepository.cs`
         */
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController() {
            _comicBookRepository = new ComicBookRepository();
        }



        public IActionResult Index()
        {
            // return a ViewResult object
            return View();
        }

        public IActionResult Info()
        {
            return Content("Hello from the comic book store.");
        }

        /*
         * `int?` means the `id` parameter is *nullable*. id may be = null
         */
        public IActionResult Detail(int? id)
        {
            if (id == null) {
                // `NotFound()` returns a 404 View to the caller
                return NotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int) id);

            return View(comicBook);
        }
    }
}
