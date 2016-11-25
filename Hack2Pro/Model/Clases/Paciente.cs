using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack2Pro.Model.Clases
{
    public class Paciente : Persona
    {
        public int PacienteId { get; set; }
        public int Planta { get; set; }
        public int HabitacionId { get; set; }
        //public virtual Habitacion Habitacion { get; set; }
    }
}