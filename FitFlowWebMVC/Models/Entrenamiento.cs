using System.ComponentModel.DataAnnotations;

namespace FitFlowWebMVC.Models
{
    public class Entrenamiento
    {
        [Key]
        public int Id { get; set; }

        public string Dia { get; set; }

        public string Ejercicio { get; set; }

        public int Series { get; set; }

        public int Repeticiones { get; set; }

        public double Peso { get; set; }

        public DateTime Fecha { get; set; }
    }
}