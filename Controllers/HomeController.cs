using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GenerarReceta(receta Receta)
    {
            ViewBag.Nombre          = Receta.nombreCocinero;
            ViewBag.Edad            = Receta.CalcularEdad();
            ViewBag.Plato           = Receta.DeterminarPlato();
            ViewBag.Tiempo          = Receta.CalcularTiempo();
            ViewBag.Dificultad      = Receta.DeterminarDificultad();
            ViewBag.CantidadPersonas = Receta.cantidadPersonas;
            ViewBag.Saludo          = Receta.GenerarSaludo();

            return View("Resultado");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
