using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class Nganh
    {
        public Nganh(string MaNganh, string TenNganh)
        {
            this.MaNganh = MaNganh;
            this.TenNganh = TenNganh;
        }
        public Nganh(DataRow row)
        {
            this.MaNganh = row["MaNganh"].ToString();
            this.TenNganh = row["TenNganh"].ToString();
        }

        private string maNganh;
        private string tenNganh;

        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
    }
}
