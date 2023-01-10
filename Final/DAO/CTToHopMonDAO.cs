using Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class CTToHopMonDAO
    {
        private static CTToHopMonDAO instance;

        public static CTToHopMonDAO Instance
        {
            get { if (instance == null) instance = new CTToHopMonDAO(); return CTToHopMonDAO.instance; }
            private set { CTToHopMonDAO.instance = value; }
        }
        private CTToHopMonDAO() { }


        public DataTable GetListCTToHopMon()
        {
            return DataProvider.Instance.ExcuteQuery("Select * from CTTOHOPMON");
        }

        public bool deleteCTToHopMonFromMaNghanhAndMaToHopMon(string maN, string maTHM)
        {

            if (maTHM == "" || maN == "")
            {
                return false;
            }
            string query = "Delete CTTOHOPMON where " + (maN != "" ? " MaNganh = " + maN : " ") + ((maN == "" && maTHM != "") ||(maN != "" && maTHM == "") ? " " : " or ")
                    + (maTHM != "" ? " MaToHopMon = N'" + maTHM + "'" : "");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<CTToHopMon> SearchListCTTHMbyByMaTHMOrMaNganh(string name)
        {
            List<CTToHopMon> listthm = new List<CTToHopMon>();
            string query = string.Format("select * from CTTOHOPMON where MaNganh = {0} or dbo.fuConvertToUnsign1(MaToHopMon) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CTToHopMon thm = new CTToHopMon(item);
                listthm.Add(thm);
            }
            return listthm;
        }

        public bool ThemChiTietToHopMon(int manganh, string maTHM)
        {
            string query = $"INSERT INTO CTTOHOPMON (MaNganh, MaToHopMon) values ({manganh}, N'{maTHM}');";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
