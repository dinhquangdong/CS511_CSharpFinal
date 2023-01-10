using Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = String.Format("select *from dbo.ACCOUNT where UserName=N'{0}' and Password=N'{1}'", userName, passWord);
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account GetAccountbyUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Account where UserName='" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        } 

        public DataTable GetAccountbyId(int Id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from ACCOUNT where Id='" + Id + "'");
            return data;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("Select Id ,UserName ,DisplayName ,Type ,Gender from ACCOUNT");
        }

        public bool UpdateAccount(int Id, float A00, float A01, float A02, float B00, float B01, float B02, float C00, float C01,
            float C02, float C03, float D01, float D07, float H00, float T00, float T03, float T04, float T05, float T06)
        {
            string query = string.Format("update ACCOUNT set A00 = {0},  A01 = {1},  A02 = {2},  B00 = {3},  B01 = {4},  B02 = {5},  C00 = {6},  C01 = {7}, C02 = {8},  C03 = {9},  D01 = {10},  D07 = {11},  H00 = {12},  T00 = {13},  T03 = {14},  T04 = {15},  T05 = {16},  T06 = {17} where Id = {18}",
                A00, A01, A02, B00, B01, B02, C00, C01, C02, C03, D01, D07, H00, T00, T03, T04, T05, T06, Id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccountById(string mk ,int Id)
        {
            string query = string.Format("update ACCOUNT set Password = N'{0}' where Id = {1}",
                mk,Id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<Account> GetListAccount_()
        {
            List<Account> listcategorie = new List<Account>();
            string query = "select * from ACCOUNT";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account category = new Account(item);
                listcategorie.Add(category);
            }
            return listcategorie;
        }

        public List<Account> SearchListAccountbyByUserOrDisplayName(string name)
        {
            List<Account> listTruong = new List<Account>();
            string query = string.Format("select * from ACCOUNT where dbo.fuConvertToUnsign1(UserName) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' or dbo.fuConvertToUnsign1(DisplayName) like N'%'+dbo.fuConvertToUnsign1('{0}')+'%' ", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account food = new Account(item);
                listTruong.Add(food);
            }
            return listTruong;
        }

        public bool ThemTaiKhoan(int id, string userName, string displayName, string gender, int type)
        {
            string query = $"INSERT INTO ACCOUNT values ({id}, N'{userName}', N'{displayName}', N'0', {type}, N'{gender}', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
