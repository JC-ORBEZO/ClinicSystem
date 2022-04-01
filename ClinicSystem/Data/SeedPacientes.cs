using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicSystem.Data
{
	public class SeedPacientes : IEntityTypeConfiguration<Paciente>
	{
		public void Configure(EntityTypeBuilder<Paciente> builder)
		{
			builder.HasData(
						 new Paciente
						 {
							 IsActive = true,
							 Nombre = "Humberto Gorosito",
							 NumHistoriaClinica = "9876541"
						 }
					 );
			builder.HasData(
						 new Paciente
						 {
							 IsActive = true,
							 Nombre = "Gustavo Gustavino",
							 NumHistoriaClinica = "9876542"
						 }
					 );
			builder.HasData(
						 new Paciente
						 {
							 IsActive = true,
							 Nombre = "Hernando Hernandez",
							 NumHistoriaClinica = "9876543"
						 }
					 );
			builder.HasData(
						 new Paciente
						 {
							 IsActive = true,
							 Nombre = "Diego Torrado",
							 NumHistoriaClinica = "9876544"
						 }
					 );
			builder.HasData(
						 new Paciente
						 {
							 IsActive = true,
							 Nombre = "Facundo Niembro",
							 NumHistoriaClinica = "9876545"
						 }
					 );
		}
	}
}
