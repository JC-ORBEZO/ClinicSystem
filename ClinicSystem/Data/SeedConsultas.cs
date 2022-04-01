using ClinicSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ClinicSystem.Data
{
    public class SeedConsultas : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            //Consulta
            builder.HasData(
                         new Consulta
                         {
                            ConsultaId=1,
                            NumMatricula ="123456",
                            NumHistoriaClinica ="9876541",
                            TipoId =1,
                            Fecha = Convert.ToDateTime("2022/03/30 12:10:15 PM"),
                            Costo =1550.50m,
                            CostoMatDescartable =0,
                            Descripcion ="Consulta Pediatria",
                            Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                            ConsultaId = 2,
                            NumMatricula = "123457",
                            NumHistoriaClinica = "9876542",
                            TipoId =1,
                            Fecha = Convert.ToDateTime("2022/03/30 12:10:15 PM"),
                            Costo = 1550.50m,
                            CostoMatDescartable =0,
                            Descripcion = "Consulta Neuro",
                            Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                            ConsultaId = 3,
                            NumMatricula = "123458",
                            NumHistoriaClinica = "9876543",
                            TipoId =1,
                            Fecha = Convert.ToDateTime("2022/03/30 12:10:15 PM"),
                            Costo = 1550.50m,
                            CostoMatDescartable =0,
                            Descripcion = "Consulta Odonto",
                            Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                            ConsultaId = 4,
                            NumMatricula = "123459",
                            NumHistoriaClinica = "9876544",
                            TipoId =1,
                            Fecha = Convert.ToDateTime("2022/03/30 12:10:15 PM"),
                            Costo = 1550.50m,
                            CostoMatDescartable =0,
                            Descripcion ="Consulta Oftalmo",
                            Active = true
                         }
                     );
            //Práctica Médica            
            builder.HasData(
                         new Consulta
                         {
                             ConsultaId = 5,
                             NumMatricula = "123456",
                             NumHistoriaClinica = "9876541",
                             TipoId = 2,
                             Fecha = Convert.ToDateTime("2022/04/30 12:10:15 PM"),
                             Costo = 1550.50m,
                             CostoMatDescartable = 1550.50m,
                             Descripcion = "P.M. Pediatria",
                             Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                             ConsultaId = 6,
                             NumMatricula = "123457",
                             NumHistoriaClinica = "9876542",
                             TipoId = 2,
                             Fecha = Convert.ToDateTime("2022/04/30 12:10:15 PM"),
                             Costo = 1550.50m,
                             CostoMatDescartable = 1550.50m,
                             Descripcion = "P.M. Neuro",
                             Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                             ConsultaId = 7,
                             NumMatricula = "123458",
                             NumHistoriaClinica = "9876543",
                             TipoId = 2,
                             Fecha = Convert.ToDateTime("2022/04/30 12:10:15 PM"),
                             Costo = 1550.50m,
                             CostoMatDescartable = 1550.50m,
                             Descripcion = "P.M. Odonto",
                             Active = true
                         }
                     );
            builder.HasData(
                         new Consulta
                         {
                             ConsultaId = 8,
                             NumMatricula = "123459",
                             NumHistoriaClinica = "9876544",
                             TipoId = 2,
                             Fecha = Convert.ToDateTime("2022/04/30 12:10:15 PM"),
                             Costo = 1550.50m,
                             CostoMatDescartable = 1550.50m,
                             Descripcion = "P.M. Oftalmo",
                             Active = true
                         }
                     );
        }
    }
}
