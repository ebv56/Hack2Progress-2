using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack2Pro.Model.Clases
{
    public class Personal : Persona
    {
        public int PersonalId { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; } //base64http o hash
        public int SeccionId { get; set; }
        //public virtual Seccion seccion { get; set; }
    }
}