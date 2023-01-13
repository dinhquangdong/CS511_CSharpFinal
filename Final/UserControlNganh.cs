using Final.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class UserControlNganh : UserControl
    {
        public static UserControlNganh Instance;
        public string TenNganh;
        public int MaNganh;
        public string AnhNganh = "messi.png";
        public UserControlNganh()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UserControlNganh_Load(object sender, EventArgs e)
        {
            labelMaNganh.Text = "Mã ngành: " + MaNganh;
            labelTenNganh.Text = TenNganh;
            pbAnhNganh.BackgroundImage = Image.FromFile("./Images/" + AnhNganh);
        }

        private void labelTenNganh_Click(object sender, EventArgs e)
        {
            MainScreen.instance.HienTruong = true;
            MainScreen.instance.HienDiem = false;
            MainScreen.instance.HienNganh = false;
            MainScreen.instance.HienToHopMon = false;

            DataTable dt = new DataTable();
            dt = TruongDAO.Instance.GetTruongFromMaNganh(MaNganh);
            MainScreen.instance.flowLayoutPanel1.Controls.Clear();            
            foreach (DataRow row in dt.Rows)
            {
                UserControlTruong t = new UserControlTruong();
                t.TenTruong = row[0].ToString();
                t.AnhTruong = row[1].ToString();

                MainScreen.instance.flowLayoutPanel1.Controls.Add(t);
            }

        }
    }
}
