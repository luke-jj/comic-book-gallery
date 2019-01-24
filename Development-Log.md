# Development Log (notes)

1. create new empty mvc core template
2. create folders: `Controllers` `Views` `Models`

3. add a first controller `Controllers/ComicBooksController.cs`
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
        public IActionResult Details()
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ComicBooks}/{action=Index}/{id?}");
            });
        }
```
