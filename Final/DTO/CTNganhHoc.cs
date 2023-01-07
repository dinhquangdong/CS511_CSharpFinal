using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class CTNganhHoc
    {
        public CTNganhHoc(string MaTruong,int MaNganh, float diemchuan)
        {
            this.MaTruong = MaTruong;
            this.MaNganh = MaNganh;
            this.DiemChuan = diemchuan;
        }
        public CTNganhHoc(DataRow row)
        {
            this.MaNganh = (int)row["MaNganh"];
            this.MaTruong = row["TenNganh"].ToString();
            this.DiemChuan = float.Parse(row["DiemChuan"].ToString());
        }

        private string maTruong;
        private int maNganh;
        private float diemChuan;

        public string MaTruong { get => maTruong; set => maTruong = value; }
        public int MaNganh { get => maNganh; set => maNganh = value; }
        public float DiemChuan { get => diemChuan; set => diemChuan = value; }
    }
}
