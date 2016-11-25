using Hack2Pro.DB;
using Hack2Pro.Model.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack2Pro.Data_BL
{
    public class SeccionBL
    {
        /// <summary>
        /// Obtiene todas las secciones
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SeccionDTO> getSecciones()
        {
            List<SeccionDTO> secciones = new List<SeccionDTO>();
            using(var hospitalDB = new HospitalDB())
            {
                secciones = hospitalDB.seccion.ToList();
            }
            return secciones;
        }

        /// <summary>
        /// Obtiene una sección
        /// </summary>
        /// <param name="id_seleccion">Id de la selección</param>
        /// <returns></returns>
        public SeccionDTO getSeleccion(int id_seleccion)
        {
            SeccionDTO seccion = new SeccionDTO();
            using(var hospitalDB = new HospitalDB())
            {
                seccion = hospitalDB.seccion.Find(id_seleccion);
            }
            return seccion;
        }
    }
}