﻿using Final.DTO;
using Microsoft.SqlServer.Server;
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

        public bool SuaChiTietNganh(string matruong, int manganh, float diemchuan)
        {
            string query = $"update CTNGANHHOC set MaTruong = N'{matruong}', MaNganh = {manganh}, DiemChuan = {diemchuan} where MaTruong = N'{matruong}'";
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

        public DataTable GetListNganhTruongDiemChuanFromMaToHopMonvaDiem(string MaThm, float diem)
        {
            string query = $"select TenTruong, TenNganh, NGANHHOC.MaNganh, DiemChuan, AnhNganh from TRUONG, NGANHHOC, CTNGANHHOC, CTTOHOPMON where TRUONG.MaTruong=CTNGANHHOC.MaTruong and NGANHHOC.MaNganh=CTNGANHHOC.MaNganh and DiemChuan<={diem} and CTTOHOPMON.MaNganh = NGANHHOC.MaNganh and CTTOHOPMON.MaToHopMon = N'{MaThm}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public DataTable GetListNganhTruongDiemChuanFromMaToHopMonvaDiemAndTimKiem(string MaThm, float diem, string timkiem)
        {
            string query = $"select TenTruong, TenNganh, NGANHHOC.MaNganh, DiemChuan, AnhNganh from TRUONG, NGANHHOC, CTNGANHHOC, CTTOHOPMON where TRUONG.MaTruong=CTNGANHHOC.MaTruong and NGANHHOC.MaNganh=CTNGANHHOC.MaNganh and DiemChuan<={diem} and CTTOHOPMON.MaNganh = NGANHHOC.MaNganh and CTTOHOPMON.MaToHopMon = N'{MaThm}' and dbo.fuConvertToUnsign1(TenNganh) like N'%'+dbo.fuConvertToUnsign1('{timkiem}')+'%'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public string getDiemMinMaxFromMaTruong(string matruong)
        {
            string query = $"select Min(DiemChuan), MAX(DiemChuan) from CTNGANHHOC where MaTruong = N'{matruong}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string result = "";
            foreach(DataRow row in dt.Rows)
            {
                result += row[0].ToString() + " - "+ row[1].ToString() + " điểm";
            }
            return result;
        }

        public DataTable GetListTruongFromMaNganh(int manganh)
        {
            string query = $"select TRUONG.MaTruong as N'Mã Trường',TRUONG.TenTruong as N'Tên trường', CTNGANHHOC.DiemChuan as N'Điểm chuẩn', CTNGANHHOC.HocPhi as N'Học phí', CTNGANHHOC.ThoiGianDaoTao as N'Thời gian học' from CTNGANHHOC, TRUONG where TRUONG.MaTruong = CTNGANHHOC.MaTruong and CTNGANHHOC.MaNganh = {manganh}";
            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
