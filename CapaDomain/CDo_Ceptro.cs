using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Ceptro
    {
        CD_Ceptro objCeptro = new CD_Ceptro();

        public void AddCeptro(Ceptro ceptro)
        {
            objCeptro.AddCeptro(ceptro);
        }
        public void UpdateCeptro(Ceptro ceptro)
        {
            objCeptro.UpdateCeptro(ceptro);
        }
        public Ceptro LoadListCeptro()
        {
            return objCeptro.LoadListCeptro();
        }
    }
}
