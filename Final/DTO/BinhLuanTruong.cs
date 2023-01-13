using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class BinhLuanTruong
    {
        public BinhLuanTruong(string MaTruong, string Gmail, string BinhLuan, float saoDanhgia)
        {
            this.MaTruong = MaTruong;
            this.Gmail = Gmail;
            this.BinhLuan = BinhLuan;
            this.SaoDanhGia = saoDanhgia;
        }
        public BinhLuanTruong(DataRow row)
        {
            this.MaTruong = row["MaTruong"].ToString();
            this.Gmail = row["Gmail"].ToString();
            this.BinhLuan = row["BinhLuan"].ToString();
            this.SaoDanhGia = (float)Convert.ToDouble(row["SaoDanhGia"].ToString());
        }

        private string maTruong;
        private string gmail;
        private string binhLuan;
        private float saoDanhGia;

        public string MaTruong { get => maTruong; set => maTruong = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string BinhLuan { get => binhLuan; set => binhLuan = value; }
        public float SaoDanhGia { get => saoDanhGia; set => saoDanhGia = value; }
    }
}
