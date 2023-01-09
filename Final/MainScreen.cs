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
        public bool HienTruong = false;
        public bool HienNganh = false;
        public bool HienDiem = false;
        public bool HienToHopMon = false;
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
            if (wbMap.Visible == true)
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

            else if(HienTruong == true)
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

            else if(HienNganh == true)
            {
                flowLayoutPanel1.Controls.Clear();
                //neu dang hien danh sach cac nganh
                DataTable dt = new DataTable();
                dt = NganhDAO.Instance.TimKiem(textBoxSearch.Text);

                foreach (DataRow row in dt.Rows)
                {
                    UserControlNganh t = new UserControlNganh();
                    t.TenNganh = row[0].ToString();
                    flowLayoutPanel1.Controls.Add(t);
                }
            }

            else if (HienDiem == true)
            {

            }

            else if (HienToHopMon == true)
            {
                flowLayoutPanel1.Controls.Clear();
                //neu dang hien danh sach cac to hop mon
                DataTable dt = new DataTable();
                dt = ToHopMonDAO.Instance.TimKiem(textBoxSearch.Text);

                foreach (DataRow row in dt.Rows)
                {
                    UserControlToHopMon t = new UserControlToHopMon();
                    t.MaTHM = row[0].ToString();
                    t.TenTHM = row[1].ToString();
                    flowLayoutPanel1.Controls.Add(t);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Khi ấn vào tất cả các trường
            HienTruong = true;
            HienDiem = false;
            HienNganh = false;
            HienToHopMon = false;

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
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;
            UserControlTrangCaNhan td = new UserControlTrangCaNhan();
            flowLayoutPanel1.Controls.Add(td);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InsertData ins = new InsertData();
            this.Hide();
            ins.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;
            UserControlTinhDiem td = new UserControlTinhDiem();
            flowLayoutPanel1.Controls.Add(td);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            panel1.Visible = true;
            wbMap.Visible = true;
            wbMap.Navigate("http://maps.google.com/maps?q=");
            buttonMapSearch.BackgroundImage = Image.FromFile("Images/map.png");
            buttonMapSearch.BackColor = Color.Transparent;
            buttonTimChu.BackColor = Color.Transparent;
            buttonTimChu.BackgroundImage = Image.FromFile("Images/search.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HienTruong = false;
            HienDiem = false;
            HienNganh = false;
            HienToHopMon = true;


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

        private void button3_Click(object sender, EventArgs e)
        {
            //Khi ấn vào tất cả các ngành
            HienTruong = false;
            HienDiem = false;
            HienNganh = true;
            HienToHopMon = false;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;

            DataTable dt = new DataTable();
            dt = NganhDAO.Instance.GetListNganh();

            foreach (DataRow row in dt.Rows)
            {
                UserControlNganh n = new UserControlNganh();
                n.TenNganh = row[0].ToString();

                flowLayoutPanel1.Controls.Add(n);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HienTruong = false;
            HienDiem = true;
            HienNganh = false;
            HienToHopMon = false;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;



        }
    }
}
