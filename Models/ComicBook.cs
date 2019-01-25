using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comic_book_gallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }


        /*
         * returns the title and issuenumber of this comic
         */
        public string DisplayText {
            get {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        /*
         * series-title-issuenumber.jpg
         * returns the filename for the associated .jpg of this comic
         */
        public string CoverImageFileName {
            get {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}
