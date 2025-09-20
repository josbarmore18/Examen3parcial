using Microsoft.AspNetCore.Mvc;
using GarajeMVC.Models;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        private Garaje miGaraje = new Garaje(1, "Garaje de [Tu Nombre Completo]", 10, 0);

        public IActionResult Index()
        {
            miGaraje.ingresarAuto(new Auto(1, "Toyota", "ABC-123"));
            miGaraje.ingresarAuto(new Auto(2, "Honda", "DEF-456"));
            miGaraje.ingresarAuto(new Auto(3, "Nissan", "GHI-789"));

            return View(miGaraje);
        }
    }
}