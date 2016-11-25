using Hack2Pro.Model.DTO_s;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hack2Pro.DB
{
    public class HospitalDB : DbContext
    {
        public DbSet<PersonalDTO> personal { get; set; }
        public DbSet<PacienteDTO> paciente { get; set; }
        public DbSet<SeccionDTO> seccion { get; set; }
        public DbSet<HabitacionDTO> habitacion { get; set; }
    }
}