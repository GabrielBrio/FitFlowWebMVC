using System.ComponentModel.DataAnnotations;

namespace FitFlowWebMVC.Models
{
    public class PlanSemanal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Dia { get; set; }

        [Required]
        public string GrupoMuscular { get; set; }

        [Required]
        public string Ejercicio { get; set; }

        [Required]
        public int Series { get; set; }

        [Required]
        public int Repeticiones { get; set; }

        [Required]
        public double Peso { get; set; }
    }
}