using Final.DTO;
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
            return DataProvider.Instance.ExcuteQuery("Select * from NGANHHOC");
        }

        public DataTable TimKiem(string text)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery($"Select TenNganh from NGANHHOc where dbo.fuConvertToUnsign1(TenNganh) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%'");
            return dt;
        }

        public DataTable GetListNganhFromMaTruong(string MaTruong)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery("select NGANHHOC.MaNganh as N'Mã Ngành', NGANHHOC.TenNganh as N'Tên Ngành', DiemChuan as N'Điểm chuẩn' from CTNGANHHOC , NGANHHOC where CTNGANHHOC.MaTruong = N'" + MaTruong+"' and NGANHHOC.MaNganh = CTNGANHHOC.MaNganh");
            return dt;
        }

        public DataTable GetListNganhFromMaTHM(string MaTHM)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery("select NGANHHOC.MaNganh, TenNganh from CTTOHOPMON, NGANHHOC where CTTOHOPMON.MaToHopMon = N'"+MaTHM+"' and NGANHHOC.MaNganh = CTTOHOPMON.MaNganh");

            return dt;
        }

        public bool deleteNganhFromMaOrTen(string ma, string ten)
        {
            CTNganhHocDAO.Instance.deleteCTNganhFromMaTruongAndMaNghanh("", ma);
            CTToHopMonDAO.Instance.deleteCTToHopMonFromMaNghanhAndMaToHopMon(ma, "");
            if (ma == "" && ten == "")
            {
                return false;
            }
            string query = "Delete NGANHHOC where " + (ma != "" ? " MaNganh = " + ma : " ") + ((ma == "" && ten != "")||(ma != "" && ten == "") ? " " : " or ")
            + (ten != "" ? " TenNganh = N'" + ten + "'" : "");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


        public bool ThemNganh(int manganh, string tennganh)
        {
            string query = $"INSERT INTO NGANHHOC (MaNganh, TenNganh) values ({manganh}, N'{tennganh}');";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
