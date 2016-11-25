using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack2Pro.Model.DTO_s
{
    public class PacienteDTO
    {
        public int PacienteId { get; set; }
        public int Planta { get; set; }
        public int HabitacionId { get; set; }
        //public virtual HabitacionDTO habitacion { get; set; }
    }
}