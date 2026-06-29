using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FitFlowWebMVC.Data;
using FitFlowWebMVC.Models;

namespace FitFlowWebMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================
        // MOSTRAR REGISTRO
        // =========================

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        // =========================
        // GUARDAR USUARIO
        // =========================

        [HttpPost]
        public IActionResult Registro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);

                _context.SaveChanges();

                return RedirectToAction("Index", "Dashboard");
            }

            return View(usuario);
        }

        // =========================
        // MOSTRAR LOGIN
        // =========================

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // =========================
        // VALIDAR LOGIN
        // =========================

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            var usuarioDB = _context.Usuarios
                .FirstOrDefault(u =>
                    u.Correo == usuario.Correo &&
                    u.Contrasena == usuario.Contrasena);

            if (usuarioDB != null)
            {
                HttpContext.Session.SetString("Usuario", usuarioDB.Nombre);

                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Correo o contraseña incorrectos";

            return View();
        }

        // =========================
        // CERRAR SESIÓN
        // =========================

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}