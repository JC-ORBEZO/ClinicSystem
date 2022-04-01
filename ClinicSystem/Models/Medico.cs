using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicSystem.Models
{
    public class Medico : Persona
    {
        [Key]
        public string NumMatricula { get; set; }
        //public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
