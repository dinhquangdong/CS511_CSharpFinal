using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class NganhDAO
    {
        private static NganhDAO instance;

        public static NganhDAO Instance
        {
            get { if (instance == null) instance = new NganhDAO(); return NganhDAO.instance; }
            private set { NganhDAO.instance = value; }
        }
        private NganhDAO() { }


        public DataTable GetListNganh()
        {
            return DataProvider.Instance.ExcuteQuery("Select TenNganh from NGANH");
        }


    }
}
