using Microsoft.EntityFrameworkCore;
using FitFlowWebMVC.Models;

namespace FitFlowWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Progreso> Progresos { get; set; }

        public DbSet<Entrenamiento> Entrenamientos { get; set; }

        public DbSet<PlanSemanal> PlanesSemanales { get; set; }



    }
}