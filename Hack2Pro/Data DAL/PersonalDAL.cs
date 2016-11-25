using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hack2Pro.DB;
using Hack2Pro.Model.DTO_s;

namespace Hack2Pro.Data_DAL
{
    public class PersonalDAL
    {
        /// <summary>Obtener lista del personal</summary>
        /// <param></param>
        /// <returns>Lista del personal</returns>
        public IEnumerable<PersonalDTO> GetPersonal()
        {
            List<PersonalDTO> personal = new List<PersonalDTO>();
            using(var hospitalDB = new HospitalDB())
            {
                personal = hospitalDB.personal.ToList();
            }
            return personal;
        }
        
        /// <summary>
        /// Obtener una sola persona del Personal
        /// </summary>
        /// <param name="id_personal">Id del usuario a buscar</param>
        /// <returns></returns>
        public PersonalDTO GetPersonal(int id_personal)
        {
            PersonalDTO personal = new PersonalDTO();
            using(var hospitalDB = new HospitalDB())
            {
                personal = hospitalDB.personal.Find(id_personal);
            }
            return personal;
        }
    }
}