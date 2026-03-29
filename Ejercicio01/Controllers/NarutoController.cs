using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
{
    public class NarutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
