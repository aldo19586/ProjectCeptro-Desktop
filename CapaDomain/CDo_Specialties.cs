using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Specialties
    {
        CD_Specialties objSpecialties = new CD_Specialties();
        public void AddSpecialty(CE_Specialty specialty)
        {
            objSpecialties.AddSpecialty(specialty);
        }
        public void UpdateSpecialty(CE_Specialty specialty)
        {
            objSpecialties.UpdateSpecialty(specialty);
        }
        public void DeleteSpecialty(int specialtyId)
        {
            objSpecialties.DeleteSpecialty(specialtyId);
        }
        public List<CE_Specialty> LoadListSpecialties()
        {
            return objSpecialties.LoadListSpecialties();
        }
    }
}
