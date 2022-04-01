using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicSystem.Models
{
    public class Consulta
    {
        [Key]
        public int ConsultaId { get; set; }
        [ForeignKey("Medico")]
        public string NumMatricula { get; set; }
        public Medico Medico { get; set; }
        [ForeignKey("Paciente")]
        public string NumHistoriaClinica { get; set; }
        public Paciente Paciente { get; set; }
        [ForeignKey("Tipo")]
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public decimal CostoMatDescartable { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }
    }
}
