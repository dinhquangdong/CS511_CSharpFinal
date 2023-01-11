using Final.DAO;
using Final.DTO;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txbTK.Text;
            string passWord = txbMK.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountbyUserName(userName);
                MainScreen c = new MainScreen(loginAccount);
                this.Hide();
                c.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong User name or Password!");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QMK qmk = new QMK();
            this.Hide();
            qmk.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dk = new DangKy();
            dk.ShowDialog();
            this.Show();
        }
    }
}
