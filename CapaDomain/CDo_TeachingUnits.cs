using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_TeachingUnits
    {
      CD_TeachingUnits objTeachingUnits = new CD_TeachingUnits();

        public void AddTeachingUnit(CE_TeachingUnit teachingUnit)
        {
           objTeachingUnits.AddTeachingUnit(teachingUnit);
        }
        public void UpdateTeachingUnit(CE_TeachingUnit teachingUnit)
        {
            objTeachingUnits.UpdateTeachingUnit(teachingUnit);
        }
        public void DeleteTeachingUnit(int teachingUnitId)
        {
            objTeachingUnits.DeleteTeachingUnit(teachingUnitId);
        }
        public List<CE_TeachingUnit2> LoadListTeachingUnits()
        {
            return objTeachingUnits.LoadListTeachingUnits();
        }

    }

}
