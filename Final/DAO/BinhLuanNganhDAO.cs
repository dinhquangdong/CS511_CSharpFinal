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
        public DataTable getListDanhGiaFromMaNganh(int manganh)
        {
            return DataProvider.Instance.ExcuteQuery($"select * from BINHLUANNGANH where MaNganh = {manganh}");
        }

        public bool insertBinhLuan(int manganh, string gmail, string binhluan, int sosao)
        {
            string query = $"Insert BINHLUANNGANH (MaNganh, Gmail, BinhLuan, SaoDanhGia, ThoiGian) values (N'{manganh}', N'{gmail}', N'{binhluan}',{sosao}, GetDate())";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}