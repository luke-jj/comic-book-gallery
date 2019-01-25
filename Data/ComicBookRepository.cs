using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comic_book_gallery.Models;

namespace comic_book_gallery.Data
{
    /*
     * Typically repositories retrieve from and persist data to a database.
     * Our data is currently embedded in our code.
     */
    public class ComicBookRepository
    {
        public static ComicBook[] _comicBooks = new ComicBook[] {
            new ComicBook() {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"},
                }
            }
            // TODO: add two more comic books
        };

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach(var comicBook in _comicBooks) {
                if (comicBook.Id == id) {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}
