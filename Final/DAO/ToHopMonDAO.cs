using Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class ToHopMonDAO
    {
        private static ToHopMonDAO instance;

        public static ToHopMonDAO Instance
        {
            get { if (instance == null) instance = new ToHopMonDAO(); return ToHopMonDAO.instance; }
            private set { ToHopMonDAO.instance = value; }
        }
        private ToHopMonDAO() { }


        public DataTable GetListTHM()
        {
            return DataProvider.Instance.ExcuteQuery("Select MaToHopMon, TenMonHoc from TOHOPMON");
        }

        public DataTable TimKiem(string text)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery($"Select MaToHopMon, TenMonHoc from TOHOPMON where dbo.fuConvertToUnsign1(TenMonHoc) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%' or dbo.fuConvertToUnsign1(MaToHopMon) like N'%'+dbo.fuConvertToUnsign1('{text}')+'%'");
            return dt;
        }

        public bool deleteToHopFromMaOrTen(string mathm, string tenthm)
        {
            CTToHopMonDAO.Instance.deleteCTToHopMonFromMaNghanhAndMaToHopMon("", mathm);

            if (mathm == "" && tenthm == "")
            {
                return false;
            }
            string query = "Delete TOHOPMON where " + (mathm != "" ? " MaToHopMon = N'" + mathm + "'" : " ") + ((mathm == "" && tenthm != "") || (mathm != "" && tenthm == "") ? " " : " or ")
                    + (tenthm != "" ? " TenMonHoc = N'" + tenthm + "'" : "");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<ToHopMon> SearchListTHMhbyByTenOrMaTHM(string name)
        {
            List<ToHopMon> listthm= new List<ToHopMon>();
            string query = string.Format("select * from TOHOPMON where dbo.fuConvertToUnsign1(TenMonHoc) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' or dbo.fuConvertToUnsign1(MaToHopMon) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ToHopMon thm = new ToHopMon(item);
                listthm.Add(thm);
            }
            return listthm;
        }

        public bool ThemToHopMon(string maTHM, string tenMH)
        {
            string query = $"INSERT INTO NGANHHOC (MaToHopMon, TenMonHoc) values (N'{maTHM}', N'{tenMH}');";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
