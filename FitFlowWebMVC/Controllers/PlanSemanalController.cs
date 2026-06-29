using Microsoft.AspNetCore.Mvc;
using FitFlowWebMVC.Data;
using FitFlowWebMVC.Models;

namespace FitFlowWebMVC.Controllers
{
    public class PlanSemanalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanSemanalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================
        // MOSTRAR FORMULARIO
        // =========================

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        // =========================
        // GUARDAR PLAN SEMANAL
        // =========================

        [HttpPost]
        public IActionResult Crear(PlanSemanal plan)
        {
            if (ModelState.IsValid)
            {
                _context.PlanesSemanales.Add(plan);

                _context.SaveChanges();

                return RedirectToAction("Historial");
            }

            return View(plan);
        }

        // =========================
        // MOSTRAR HISTORIAL
        // =========================

        public IActionResult Historial()
        {
            var planes = _context.PlanesSemanales
                .OrderBy(p => p.Id)
                .ToList();

            return View(planes);
        }
    }
}