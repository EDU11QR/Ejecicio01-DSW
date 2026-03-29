using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
{
    public class DragonBallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
