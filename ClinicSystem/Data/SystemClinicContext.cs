using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicSystem.Data
{
    public class SystemClinicContext : DbContext
    {
        public SystemClinicContext(DbContextOptions<SystemClinicContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedPacientes());
            modelBuilder.ApplyConfiguration(new SeedMedicos());
            modelBuilder.ApplyConfiguration(new SeedTipoes());
            modelBuilder.ApplyConfiguration(new SeedConsultas());
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
