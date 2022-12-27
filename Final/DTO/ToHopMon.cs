using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DTO
{
    public class ToHopMon
    {
        public ToHopMon(string MaToHopMon, string TenMonHoc)
        {
            this.MaToHopMon = MaToHopMon;
            this.TenMonHoc = TenMonHoc;
            
        }
        public ToHopMon(DataRow row)
        {
            this.MaToHopMon = row["MaToHopMon"].ToString();
            this.TenMonHoc = row["TenTruong"].ToString();
            
        }

        private string maToHopMon;
        private string tenMonHoc;


        public string MaToHopMon { get => maToHopMon; set => maToHopMon = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        
    }
}
