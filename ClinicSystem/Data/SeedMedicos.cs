using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicSystem.Data
{
	public class SeedMedicos : IEntityTypeConfiguration<Medico>
	{
		public void Configure(EntityTypeBuilder<Medico> builder)
		{
			builder.HasData(
						 new Medico
						 {
							 IsActive = true,
							 Nombre = "Juan Achaval",
							 NumMatricula = "123456",
							 Especialidad = "Pediatria"
						 }
					 );
			builder.HasData(
						 new Medico
						 {
							 IsActive = true,
							 Nombre = "Agus Repetto",
							 NumMatricula = "123457",
							 Especialidad = "Neurologia"
						 }
					 );
			builder.HasData(
						 new Medico
						 {
							 IsActive = true,
							 Nombre = "Lautaro Diaz",
							 NumMatricula = "123458",
							 Especialidad = "Odontologia"
						 }
					 );
			builder.HasData(
						 new Medico
						 {
							 IsActive = true,
							 Nombre = "Felipe Gonzales",
							 NumMatricula = "123459",
							 Especialidad = "Oftalmologia"
						 }
					 );
		}
	}
}
