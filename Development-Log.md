# Development Log (just some notes)

1. Create new empty mvc core template
2. Create folders: `Controllers` `Views` `Models`

3. Add a first controller `Controllers/ComicBooksController.cs`
```cs
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
        public IActionResult Info()
        {
            return Content("Hello from the comic book store.");
        }
    }
}
```

4. Configure `Startup.cs`
```cs
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
```

```cs
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ComicBooks}/{action=Index}/{id?}");
            });
        }
```





5. create the first view file under `/Views/ComicBooks/Index.cshtml`
```html
@{
    ViewData["Title"] = "Comic Books Store";
}

<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device=width">
        <title>@ViewData["Title"]</title>
    </head>
    <body>
        <div>
            <h1>Welcome To The Comic Book Store</h1>
            <p>WHY hello there</p>
        </div>
    </body>
</html>
```
6. add a new method to the ComicBooks Controller that references the new view
```cs
        public IActionResult Index()
        {
            // return a ViewResult object
            return View();
        }
```

7. add new views + associated methods in the controller as desired





8. Add all design files under the folder `/wwwroot/` (.js, .css, .png)
9. Add a Shared View as `/Views/Shared/_Layout.cshtml`




10. Add a datamodel for comic books under `/Models/ComicBook.cs`
11. Add related subdatamodel for artists under `/Models/Artist.cs`
```cs
namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}
```

```cs
namespace ComicBookGallery.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
```

Instantiate the data model instances in the relevant controller class under
the relevant action and pass them to the view in the return statement.
```cs
        public IActionResult Detail()
        {
            var comicBook = new ComicBook() {
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
            };

            return View(comicBook);
        }
```
