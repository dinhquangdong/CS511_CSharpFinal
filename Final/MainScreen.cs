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
            if(flowLayoutPanel1.Visible == true)
            {
                flowLayoutPanel1.Controls.Clear();
                //neu dang hien danh sach cac truong dai hoc
                DataTable dt = new DataTable();
                dt = TruongDAO.Instance.TimKiem(textBoxSearch.Text);

                foreach (DataRow row in dt.Rows)
                {
                    UserControlTruong t = new UserControlTruong();
                    t.TenTruong = row[0].ToString();
                    t.AnhTruong = row[1].ToString();

                    flowLayoutPanel1.Controls.Add(t);
                }
            }
            
            if(wbMap.Visible == true)
            {
                //neu dang hien map
                try
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("http://maps.google.com/maps?q=");
                    if (textBoxSearch.Text != string.Empty)
                    {
                        stringBuilder.Append(textBoxSearch.Text);
                    }
                    wbMap.Navigate(stringBuilder.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            panel1.Visible = true;
            wbMap.Visible = true;
            wbMap.Navigate("http://maps.google.com/maps?q=");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;

            DataTable dt = new DataTable();
            dt = ToHopMonDAO.Instance.GetListTHM();

            foreach (DataRow row in dt.Rows)
            {
                UserControlToHopMon t = new UserControlToHopMon();
                t.MaTHM = row[0].ToString();
                t.TenTHM = row[1].ToString();

                flowLayoutPanel1.Controls.Add(t);
            }
        }
    }
}
