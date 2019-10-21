using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApp.API.Controllers
{
    public class FallbackController : Controller  //Controller will give view support b/c angular files will return a view
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot", "index.html"), "text/HTML");
        }
    }
}