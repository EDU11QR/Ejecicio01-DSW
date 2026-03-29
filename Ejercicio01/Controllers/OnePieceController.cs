using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
{
    public class OnePieceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
