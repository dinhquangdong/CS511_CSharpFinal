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

        public DataTable getListDanhGiaFromMaTruong(string Matruong)
        {
            DataTable dt = new DataTable();
            string query = $"select * from BINHLUANTRUONG where MaTruong = N'{Matruong}'";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public bool insertBinhLuan(string MaTruong, string gmail, string binhluan,int sosao)
        {
            string query = $"Insert BINHLUANTRUONG (MaTruong, Gmail, BinhLuan, SaoDanhGia, ThoiGian) values (N'{MaTruong}', N'{gmail}', N'{binhluan}',{sosao}, GetDate())";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
