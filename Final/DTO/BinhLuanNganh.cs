using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class BinhLuanNganh
    {
        public BinhLuanNganh(string MaNganh, string Gmail, string BinhLuan, float saoDanhgia)
        {
            this.MaNganh = MaNganh;
            this.Gmail = Gmail;
            this.BinhLuan = BinhLuan;
            this.SaoDanhGia = saoDanhgia;
        }
        public BinhLuanNganh(DataRow row)
        {
            this.MaNganh = row["MaNganh"].ToString();
            this.Gmail = row["Gmail"].ToString();
            this.BinhLuan = row["BinhLuan"].ToString();
            this.SaoDanhGia = (float)Convert.ToDouble(row["SaoDanhGia"].ToString());
        }

        private string maNganh;
        private string gmail;
        private string binhLuan;
        private float saoDanhGia;

        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string BinhLuan { get => binhLuan; set => binhLuan = value; }
        public float SaoDanhGia { get => saoDanhGia; set => saoDanhGia = value; }
    }
}
