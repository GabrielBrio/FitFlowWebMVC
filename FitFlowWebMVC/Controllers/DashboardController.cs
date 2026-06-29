using Microsoft.AspNetCore.Mvc;

namespace FitFlowWebMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var usuario = HttpContext.Session.GetString("Usuario");

            if (usuario == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            ViewBag.Usuario = usuario;

            return View();
        }
    }
}