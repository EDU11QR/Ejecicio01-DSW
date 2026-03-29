using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Animes()
        {
            return View();
        }

    }
}
