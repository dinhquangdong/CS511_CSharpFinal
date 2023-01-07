using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class CTNganhHocDAO
    {
        private static CTNganhHocDAO instance;

        public static CTNganhHocDAO Instance
        {
            get { if (instance == null) instance = new CTNganhHocDAO(); return CTNganhHocDAO.instance; }
            private set { CTNganhHocDAO.instance = value; }
        }
        private CTNganhHocDAO() { }


        public DataTable GetListCTToHopMon()
        {
            return DataProvider.Instance.ExcuteQuery("Select * from CTNGANHHOC");
        }


    }
}
