using System.ComponentModel.DataAnnotations;

namespace FitFlowWebMVC.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Contrasena { get; set; }

        public int Peso { get; set; }

        public int Altura { get; set; }

        public string Objetivo { get; set; }
    }
}