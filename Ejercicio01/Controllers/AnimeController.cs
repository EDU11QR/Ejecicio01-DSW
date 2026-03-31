using Ejercicio01.Models;
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

        public IActionResult CalculoCotizar(ClassCotizar objcotizar)
        {
            //pequeño algoritmo...
            //aplicamos un switch....
            string ani = objcotizar.Canime;
            switch (ani)
            {

                case "Dragon01":
                    // asignamos un precio
                    objcotizar.Precio = 140;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "Dragon02":
                    // asignamos un precio
                    objcotizar.Precio = 200;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "Dragon03":
                    // asignamos un precio
                    objcotizar.Precio = 100;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "Naruto01":
                    // asignamos un precio
                    objcotizar.Precio = 350;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "Naruto02":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "Naruto03":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePiece01":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePiece02":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePiece03":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePunch1":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePunch2":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

                case "OnePunch3":
                    // asignamos un precio
                    objcotizar.Precio = 120;
                    objcotizar.Total = objcotizar.Precio * objcotizar.Cantidad;
                    break;

            } //fin del switch

            // retorna la visra
            return View(objcotizar);

        } // fin del metodo

        public IActionResult Cotizar()
        {
            return View();
        }

    }
}
