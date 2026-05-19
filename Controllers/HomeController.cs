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

    
    public IActionResult GenerarReceta(Receta receta)
    {
        ViewBag.Nombre           = receta.NombreCocinero;
        ViewBag.Edad             = receta.CalcularEdad();
        ViewBag.Plato            = receta.DeterminarPlato();
        ViewBag.Tiempo           = receta.CalcularTiempo();
        ViewBag.Dificultad       = receta.DeterminarDificultad();
        ViewBag.CantidadPersonas = receta.CantidadPersonas;
        ViewBag.Saludo           = receta.GenerarSaludo();

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