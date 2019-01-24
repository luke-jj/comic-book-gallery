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
