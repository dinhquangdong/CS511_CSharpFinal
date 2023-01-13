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
    public partial class UserControlTruong : UserControl
    {
        public static UserControlTruong Instance;
        public string TenTruong;
        public string AnhTruong;
        public string MinMaxDiem;
        public UserControlTruong()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UserControlTruong_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("Images/" + AnhTruong);
            labelName.Text = TenTruong;
            lbMinMaxDiem.Text = MinMaxDiem;
        }

        private void UserControlTruong_Click(object sender, EventArgs e)
        {
            MainScreen.instance.BLNganh = false;
            string MaTruong = TruongDAO.Instance.GetMaTruong(TenTruong);
            DataTable dt = new DataTable();
            dt = TruongDAO.Instance.GetThongTinTruongFromMaTruong(MaTruong);
            ChiTietTruong ctt = new ChiTietTruong();
            ctt.ThongTinTruong = dt;
            ctt.ShowDialog();
            MainScreen.instance.MainScreen_Load1();
        }

        private void UserControlTruong_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            labelName.ForeColor = Color.FromArgb(66, 166, 244);
        }

        private void UserControlTruong_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(66, 166, 244);
            labelName.ForeColor = Color.White;
        }
    }
}
