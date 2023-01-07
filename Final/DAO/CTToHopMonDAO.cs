using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class CTToHopMonDAO
    {
        private static CTToHopMonDAO instance;

        public static CTToHopMonDAO Instance
        {
            get { if (instance == null) instance = new CTToHopMonDAO(); return CTToHopMonDAO.instance; }
            private set { CTToHopMonDAO.instance = value; }
        }
        private CTToHopMonDAO() { }


        public DataTable GetListCTToHopMon()
        {
            return DataProvider.Instance.ExcuteQuery("Select * from CTTOHOPMON");
        }


    }
}
