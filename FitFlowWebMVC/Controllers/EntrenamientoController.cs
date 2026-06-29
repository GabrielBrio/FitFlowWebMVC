using Microsoft.AspNetCore.Mvc;
using FitFlowWebMVC.Data;
using FitFlowWebMVC.Models;

namespace FitFlowWebMVC.Controllers
{
    public class EntrenamientoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntrenamientoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Entrenamiento entrenamiento)
        {
            entrenamiento.Fecha = DateTime.Now;

            _context.Entrenamientos.Add(entrenamiento);

            _context.SaveChanges();

            return RedirectToAction("Index", "Dashboard");
        }
        public IActionResult Historial()
        {
            var entrenamientos = _context.Entrenamientos
                .OrderByDescending(e => e.Fecha)
                .ToList();

            return View(entrenamientos);
        }
        public IActionResult Sugerencias()
        {
            var entrenamientos = _context.Entrenamientos
                .OrderByDescending(e => e.Fecha)
                .ToList();

            var sugerencias = entrenamientos
                .Select(e =>
                {
                    double nuevoPeso = e.Peso;

                    // PROGRESIÓN AUTOMÁTICA

                    if (e.Repeticiones >= 12)
                    {
                        nuevoPeso += 5;
                    }
                    else if (e.Repeticiones >= 10)
                    {
                        nuevoPeso += 2.5;
                    }

                    return new Entrenamiento
                    {
                        Dia = e.Dia,
                        Ejercicio = e.Ejercicio,
                        Series = e.Series,
                        Repeticiones = e.Repeticiones,
                        Peso = nuevoPeso,
                        Fecha = DateTime.Now
                    };
                })
                .ToList();

            return View(sugerencias);
        }




    }
}