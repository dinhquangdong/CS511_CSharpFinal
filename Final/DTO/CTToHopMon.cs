using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Final.DTO
{
    public class CTToHopMon
    {
        public CTToHopMon(int MaNganh, string matohopmon)
        {
            this.MaNganh = MaNganh;
            this.MaToHopMon = matohopmon;
        }
        public CTToHopMon(DataRow row)
        {
            this.MaNganh = (int)row["MaNganh"];
            this.MaToHopMon = row["MaToHopMon"].ToString();
        }

        private int maNganh;
        private string maToHopMon;

        public int MaNganh { get => maNganh; set => maNganh = value; }
        public string MaToHopMon { get => maToHopMon; set => maToHopMon = value; }
    }
}
