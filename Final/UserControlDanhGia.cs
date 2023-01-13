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
    public partial class UserControlDanhGia : UserControl
    {
        public string TenHienThi;
        public string LoiNhanXet;
        public string SoSao;
        public string ThoiGianBL;
        public string LoaiTG;
        public UserControlDanhGia()
        {
            InitializeComponent();
        }

        private void UserControlDanhGia_Load(object sender, EventArgs e)
        {
            pbSao.BackgroundImage = Image.FromFile("./Images/filled_select.png");
            this.Height = 66 + lbBinhLuan.Height;
            lbTenHienThiUser.Text = TenHienThi;
            lbBinhLuan.Text = LoiNhanXet;
            lbSoSao.Text = SoSao;
            lbThoiGian.Text = ThoiGianBL;
            lbLoaiTG.Text = LoaiTG;
        }
    }
}
