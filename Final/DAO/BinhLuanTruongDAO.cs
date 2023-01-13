using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class BinhLuanTruongDAO
    {
        private static BinhLuanTruongDAO instance;

        public static BinhLuanTruongDAO Instance
        {
            get { if (instance == null) instance = new BinhLuanTruongDAO(); return BinhLuanTruongDAO.instance; }
            private set { BinhLuanTruongDAO.instance = value; }
        }
        private BinhLuanTruongDAO() { }
    }
}
