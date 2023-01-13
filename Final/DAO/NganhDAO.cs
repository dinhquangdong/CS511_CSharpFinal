using Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public DataTable GetAnhNganhFromMaNganh(int manganh)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery($"select AnhNganh from NGANHHOC where MaNganh = N'{manganh}'");
            return dt;
        }

        public DataTable TimKiem(string text)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery($"Select TenNganh, MaNganh from NGANHHOC where dbo.fuConvertToUnsign1(TenNganh) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%' or dbo.fuConvertToUnsign1(MaNganh) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%' ");
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
        public List<Nganh> SearchListNganhbyByTenOrMaNganh(string name)
        {
            List<Nganh> listTruong = new List<Nganh>();
            string query = string.Format("select * from NGANHHOC where dbo.fuConvertToUnsign1(TenNganh) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' or dbo.fuConvertToUnsign1(MaNganh) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Nganh food = new Nganh(item);
                listTruong.Add(food);
            }
            return listTruong;
        }


        public bool ThemNganh(int manganh, string tennganh)
        {
            string query = $"INSERT INTO NGANHHOC (MaNganh, TenNganh) values ({manganh}, N'{tennganh}');";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
