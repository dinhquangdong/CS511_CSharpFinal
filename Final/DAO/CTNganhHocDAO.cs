using Final.DTO;
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


        public DataTable GetListCTNganh()
        {
            return DataProvider.Instance.ExcuteQuery("Select * from CTNGANHHOC");
        }

        public DataTable GetListDiemChuanFromDiem(int From, int To)
        {
            return DataProvider.Instance.ExcuteQuery("select TenTruong as N'Tên Trường', TenNganh as N'Tên Ngành', DiemChuan as N'Điểm chuẩn' From TRUONG,NGANHHOC, CTNGANHHOC where TRUONG.MaTruong = CTNGANHHOC.MaTruong and NGANHHOC.MaNganh = CTNGANHHOC.MaNganh and DiemChuan between " + From + " and " + To);
        }

        public DataTable GetListDiemChuanFromTenTruong(int From, int To, string TenTruong)
        {
            return DataProvider.Instance.ExcuteQuery("select TenTruong as N'Tên Trường', TenNganh as N'Tên Ngành', DiemChuan as N'Điểm chuẩn' From TRUONG,NGANHHOC, CTNGANHHOC where TRUONG.MaTruong = CTNGANHHOC.MaTruong and NGANHHOC.MaNganh = CTNGANHHOC.MaNganh and TRUONG.TenTruong = N'"+TenTruong+"' and DiemChuan between " + From + " and " + To);
        }

        public bool deleteCTNganhFromMaTruongAndMaNghanh(string maT, string maN)
        {

            if (maT == "" && maN == "")
            {
                return false;
            }
            string query = "Delete CTNGANHHOC where" + (maN != "" ? " MaNganh = " + maN : " ") + ((maN == "" && maT != "") || (maN != "" && maT == "") ? " " : " or ")
                    + (maT != "" ? " MaTruong = N'" + maT + "'" : "");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool ThemChiTietNganh(string matruong, int manganh, float diemchuan)
        {
            string query = $"INSERT INTO CTNGANHHOC (MaTruong, MaNganh, DiemChuan) values (N'{matruong}', {manganh}, {diemchuan});";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public List<CTNganhHoc> SearchListCTNganhbyByMaTruongOrMaNganh(string name)
        {
            List<CTNganhHoc> listthm = new List<CTNganhHoc>();
            string query = string.Format("select * from CTNGANHHOC where MaNganh = {0} or dbo.fuConvertToUnsign1(MaTruong) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTNganhHoc thm = new CTNganhHoc(item);
                listthm.Add(thm);
            }
            return listthm;
        }
    }
}
