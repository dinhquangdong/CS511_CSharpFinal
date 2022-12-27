using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class Truong
    {
        public Truong(string MaTruong, string TenTruong, string LinkWebTruong, string DiaChi, string SDT, float SaoDanhGia, string ReView, string AnhTruong)
        {
            this.MaTruong = MaTruong;
            this.TenTruong = TenTruong;
            this.LinkWebTruong = LinkWebTruong;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.SaoDanhGia = SaoDanhGia;
            this.ReView = ReView;
            this.AnhTruong = AnhTruong;
        }
        public Truong(DataRow row)
        {
            this.MaTruong = row["MaTruong"].ToString();
            this.TenTruong = row["TenTruong"].ToString();
            this.LinkWebTruong = row["LinkWebTruong"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.SaoDanhGia = float.Parse(row["SaoDanhGia"].ToString());
            this.ReView = row["ReView"].ToString();
            this.AnhTruong = row["AnhTruong"].ToString();
        }

        private string maTruong;
        private string tenTruong;
        private string linkWebTruong;
        private string diaChi;
        private string sDT;
        private float saoDanhGia;
        private string reView;
        private string anhTruong;

        public string MaTruong { get => maTruong; set => maTruong = value; }
        public string TenTruong { get => tenTruong; set => tenTruong = value; }
        public string LinkWebTruong { get => linkWebTruong; set => linkWebTruong = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public float SaoDanhGia { get => saoDanhGia; set => saoDanhGia = value; }
        public string ReView { get => reView; set => reView = value; }
        public string AnhTruong { get => anhTruong; set => anhTruong = value; }
    }
}

