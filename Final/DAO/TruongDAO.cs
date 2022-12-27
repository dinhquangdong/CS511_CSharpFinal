using Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class TruongDAO
    {
        private static TruongDAO instance;

        public static TruongDAO Instance
        {
            get { if (instance == null) instance = new TruongDAO(); return TruongDAO.instance; }
            private set { TruongDAO.instance = value; }
        }
        private TruongDAO() { }

       
        public DataTable GetListTruong()
        {
            return DataProvider.Instance.ExcuteQuery("Select TenTruong,AnhTruong from TRUONG");
        }


    }
}
