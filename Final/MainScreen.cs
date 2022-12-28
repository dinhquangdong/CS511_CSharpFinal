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
    public partial class MainScreen : Form
    {
        public static MainScreen instance;
        public MainScreen()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonMapSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            wbMap.Visible = true;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("http://maps.google.com/maps?q=");
                wbMap.Navigate(stringBuilder.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            wbMap.Visible = true;
            flowLayoutPanel1.Visible = false;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("http://maps.google.com/maps?q=");
                if(textBoxSearch.Text != string.Empty)
                {
                    stringBuilder.Append(textBoxSearch.Text);
                }
                wbMap.Navigate(stringBuilder.ToString());
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wbMap.Visible = false;
            flowLayoutPanel1.Visible = true;
            DataTable dt = new DataTable();
            dt = TruongDAO.Instance.GetListTruong();
            flowLayoutPanel1.Controls.Clear();
            foreach(DataRow row in dt.Rows)
            {
                UserControlTruong t = new UserControlTruong();
                t.TenTruong = row[0].ToString();
                t.AnhTruong = row[1].ToString();

                flowLayoutPanel1.Controls.Add(t);
            }
        }
    }
}
