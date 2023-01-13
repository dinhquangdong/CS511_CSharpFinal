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
    public partial class UserControlNganhGoiY : UserControl
    {
        public UserControlNganhGoiY()
        {
            InitializeComponent();
        }

        public string tentruong, tennganh;
        public float diemchuan;
        public int manganh;
        public string AnhNganh;

        private void UserControlNganhGoiY_Click(object sender, EventArgs e)
        {
            MainScreen.instance.BLNganh = true;

            DataTable dt = new DataTable();
            dt = NganhDAO.Instance.GetThongTinNganhFromMaNganh(manganh);

            ChiTietNganh ctn = new ChiTietNganh();
            ctn.ThongTinNganh = dt;

            MainScreen.instance.Hide();
            ctn.ShowDialog();
            MainScreen.instance.Show();
        }

        private void UserControlNganhGoiY_Load(object sender, EventArgs e)
        {
            labelTenTruong.Text = tentruong;
            labelTenNganh.Text = tennganh;
            labelDiemChuan.Text = "Điểm chuẩn: " + diemchuan.ToString();
            labelMaNganh.Text = "Mã ngành: " + manganh.ToString();
            pbAnhNganh.BackgroundImage = Image.FromFile("./Images/" + AnhNganh);
        }
    }
}
