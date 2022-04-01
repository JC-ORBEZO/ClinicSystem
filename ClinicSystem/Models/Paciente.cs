using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicSystem.Models
{
    public class Paciente : Persona
    {
        [Key]
        public string NumHistoriaClinica { get; set; }
        //public string Nombre { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
