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
        public string AnhNganh;
        public UserControlNganh()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UserControlNganh_Load(object sender, EventArgs e)
        {
            DataTable dt = NganhDAO.Instance.GetAnhNganhFromMaNganh(MaNganh);
            foreach(DataRow r in dt.Rows)
                AnhNganh = r["AnhNganh"].ToString();

            labelMaNganh.Text = "Mã ngành: " + MaNganh;
            labelTenNganh.Text = TenNganh;
            pbAnhNganh.BackgroundImage = Image.FromFile("Images/" + AnhNganh);
        }

        private void labelTenNganh_Click(object sender, EventArgs e)
        {
            MainScreen.instance.BLNganh = true;

            DataTable dt = new DataTable();
            dt = NganhDAO.Instance.GetThongTinNganhFromMaNganh(MaNganh);

            ChiTietNganh ctn = new ChiTietNganh();
            ctn.ThongTinNganh = dt;

            MainScreen.instance.Hide();
            ctn.ShowDialog();
            MainScreen.instance.Show();

        }
    }
}
