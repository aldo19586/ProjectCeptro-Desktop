using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Tuition
    {
        CD_Tuition  objTuition = new CD_Tuition();
        public void AddTuition(CE_Tuition Tuition)
        {
           objTuition.AddTuition(Tuition);  
        }
        public void UpdateTuition(CE_Tuition Tuition)
        {
           objTuition.UpdateTuition(Tuition);
        }
        public void DeleteTuition(int TuitionId)
        {
            objTuition.DeleteTuition(TuitionId);
        }
        public DataTable SearchTuition(string buscar)
        {
            return objTuition.SearchTuition(buscar);
        }
        public List<CE_Tuition> LoadListTuitions()
        {
            return objTuition.LoadListTuitions();

    }
}
}
