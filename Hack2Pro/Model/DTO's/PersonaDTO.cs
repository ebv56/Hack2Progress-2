using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack2Pro.Model.DTO_s
{
    public class PersonaDTO
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Tlf { get; set; }
        public string Direccion { get; set; }
    }
}