using Microsoft.AspNetCore.Mvc;
using FitFlowWebMVC.Data;
using FitFlowWebMVC.Models;

namespace FitFlowWebMVC.Controllers
{
    public class ProgresoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgresoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Progreso progreso)
        {
            progreso.Fecha = DateTime.Now;

            _context.Progresos.Add(progreso);

            _context.SaveChanges();

            return RedirectToAction("Index", "Dashboard");
        }
        public IActionResult Historial()
        {
            var progresos = _context.Progresos
                .OrderByDescending(p => p.Fecha)
                .ToList();

            return View(progresos);
        }
    }
}