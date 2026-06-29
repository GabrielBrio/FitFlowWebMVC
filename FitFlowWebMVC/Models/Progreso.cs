using System.ComponentModel.DataAnnotations;

namespace FitFlowWebMVC.Models
{
    public class Progreso
    {
        [Key]
        public int Id { get; set; }

        public double Peso { get; set; }

        public double Pecho { get; set; }

        public double Cintura { get; set; }

        public double Brazos { get; set; }

        public double Piernas { get; set; }

        public DateTime Fecha { get; set; }
    }
}