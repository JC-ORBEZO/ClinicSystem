using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicSystem.Data
{
    public class SeedTipoes : IEntityTypeConfiguration<Tipo>
	{
		public void Configure(EntityTypeBuilder<Tipo> builder)
		{
			builder.HasData(
						 new Tipo
						 {
							 TipoId=1,
							 Descripcion="Consultorio"
						 }
					 );
			builder.HasData(
						 new Tipo
						 {
							 TipoId = 2,
							 Descripcion = "Practica Medica"
						 }
					 );
		}
    }
}
