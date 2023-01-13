using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class BinhLuanNganhDAO
    {
        private static BinhLuanNganhDAO instance;

        public static BinhLuanNganhDAO Instance
        {
            get { if (instance == null) instance = new BinhLuanNganhDAO(); return BinhLuanNganhDAO.instance; }
            private set { BinhLuanNganhDAO.instance = value; }
        }
        private BinhLuanNganhDAO() { }
    }
}