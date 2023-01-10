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
    public partial class UserControlTrangCaNhan : UserControl
    {

        public UserControlTrangCaNhan()
        {
            InitializeComponent();
            pbAvatar.BackgroundImage = Image.FromFile("./Images/avatar.png");
        }

        private void UserControlTrangCaNhan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = AccountDAO.Instance.GetAccountbyId(MainScreen.instance.Id);
            foreach(DataRow r in dt.Rows)
            {
                lbTen.Text = r[2].ToString() + "(" + r[1].ToString() + ")";
                lbGioiTinh.Text = r[5].ToString();
                txbA00.Text = r[6].ToString();
                txbA01.Text = r[7].ToString();
                txbA02.Text = r[8].ToString();
                txbB00.Text = r[9].ToString();
                txbB01.Text = r[10].ToString();
                txbB02.Text = r[11].ToString();
                txbC00.Text = r[12].ToString();
                txbC01.Text = r[13].ToString();
                txbC02.Text = r[14].ToString();
                txbC03.Text = r[15].ToString();
                txbD01.Text = r[16].ToString();
                txbD07.Text = r[17].ToString();
                txbH00.Text = r[18].ToString();
                txbT00.Text = r[19].ToString();
                txbT03.Text = r[20].ToString();
                txbT04.Text = r[21].ToString();
                txbT05.Text = r[22].ToString();
                txbT06.Text = r[23].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbMKcu.Text == MainScreen.instance.matkhau)
            {
                if (AccountDAO.Instance.UpdateAccountById(txbMKmoi.Text, MainScreen.instance.Id))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu Thất bại", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
