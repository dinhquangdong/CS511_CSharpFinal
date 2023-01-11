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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {

            if (AccountDAO.Instance.ThemTaiKhoan(txbGmail.Text, txbTK.Text, txbTenHienThi.Text,txbMK.Text, txbGioiTinh.Text))
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
            }
        }
    }
}
