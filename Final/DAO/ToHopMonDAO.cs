using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class ToHopMonDAO
    {
        private static ToHopMonDAO instance;

        public static ToHopMonDAO Instance
        {
            get { if (instance == null) instance = new ToHopMonDAO(); return ToHopMonDAO.instance; }
            private set { ToHopMonDAO.instance = value; }
        }
        private ToHopMonDAO() { }


        public DataTable GetListTruong()
        {
            return DataProvider.Instance.ExcuteQuery("Select TenToHopMon from TOHOPMON");
        }


    }
}
