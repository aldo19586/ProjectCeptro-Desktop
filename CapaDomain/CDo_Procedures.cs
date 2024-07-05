using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDomain
{
    public class CDo_Procedures
    {
        CD_Connection connection;
        CD_Procedures objProcedures = new CD_Procedures();
        public bool VerifyTextBoxs(Form form)
        {
            return objProcedures.VerifyControls(form);
        }
        public void ReplaceDatabase(string releaseDirectory)
        {
           objProcedures.ReplaceDatabase(releaseDirectory);
        }
        public List<SpecialtyXteachingUnit> LoadListSpecialtyXteachingUnit()
        {
           return objProcedures.LoadListSpecialtyXteachingUnit();
        }
    }
}
