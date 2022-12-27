using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=TimTruongDaiHoc;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }

        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                connection.Close();
                data = command.ExecuteNonQuery();
            }
            return data;
        }

        public object ExcuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                connection.Close();
                data = command.ExecuteScalar();
            }
            return data;
        }

    }
}
