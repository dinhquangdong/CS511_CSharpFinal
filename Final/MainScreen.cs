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
        public Image avatar;

        public bool BLNganh = false;
        public bool GoiYNganh = false;

        public bool HienTruong = false;
        public bool HienNganh = false;
        public bool HienDiem = false;
        public bool HienToHopMon = false;
        public string DiaChiCanDen;
        public string Gmail;
        public string matkhau;
        public int type;
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
            }
        }
        public MainScreen(Account acc)
        {
            InitializeComponent();
            instance = this;
            this.LoginAccount = acc;
            Gmail = acc.Gmail;
            type = acc.Type;
            matkhau = acc.Password;
            pblogo.BackgroundImage = Image.FromFile("./Images/logo.png");
            avatar = Image.FromFile("Images/avatar.png");
            placeholderSearch("Nhập từ khóa cần tìm");
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

        public void placeholderSearch(string s)
        {
            textBoxSearch.Text = s;
            textBoxSearch.GotFocus += TextBoxSearch_GotFocus;
            textBoxSearch.LostFocus += TextBoxSearch_LostFocus;
        }
        public void TextBoxSearch_LostFocus(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Nhập từ khóa cần tìm";
                textBoxSearch.ForeColor = Color.DimGray;
            }
        }

        public void TextBoxSearch_GotFocus(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Nhập từ khóa cần tìm")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.FromArgb(60,60,60);
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

            else if (HienTruong == true)
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
                    t.MinMaxDiem = CTNganhHocDAO.Instance.getDiemMinMaxFromMaTruong(row[2].ToString());
                    flowLayoutPanel1.Controls.Add(t);
                }
            }

            else if (HienNganh == true)
            {
                flowLayoutPanel1.Controls.Clear();
                //neu dang hien danh sach cac nganh
                DataTable dt = new DataTable();
                dt = NganhDAO.Instance.TimKiem(textBoxSearch.Text);

                foreach (DataRow row in dt.Rows)
                {
                    UserControlNganh t = new UserControlNganh();
                    t.TenNganh = row[0].ToString();
                    t.MaNganh = int.Parse(row[1].ToString());
                    flowLayoutPanel1.Controls.Add(t);
                }
            }

            else if (GoiYNganh == true)
            {
                UserControlGoiYNganh.instance.flowLayoutPanel1.Controls.Clear();

                DataTable dt = new DataTable();
                dt = AccountDAO.Instance.GetListDiemFromGmail(Gmail);

                DataTable dt3 = new DataTable();
                float diem = 0;
                DataRow r = dt.Rows[0];
                diem = float.Parse(r[dt.Columns.IndexOf(UserControlGoiYNganh.instance.comboBox1.Text)].ToString());
                dt3 = CTNganhHocDAO.Instance.GetListNganhTruongDiemChuanFromMaToHopMonvaDiemAndTimKiem(UserControlGoiYNganh.instance.comboBox1.Text, diem, textBoxSearch.Text);
                UserControlGoiYNganh.instance.lbSoNganh.Text = dt3.Rows.Count.ToString();
                foreach (DataRow dr in dt3.Rows)
                {
                    UserControlNganhGoiY u = new UserControlNganhGoiY();
                    u.tentruong = dr[0].ToString();
                    u.tennganh = dr[1].ToString();
                    u.manganh = int.Parse(dr[2].ToString());
                    u.diemchuan = float.Parse(dr[3].ToString());
                    u.AnhNganh = dr[4].ToString();
                    UserControlGoiYNganh.instance.flowLayoutPanel1.Controls.Add(u);
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            pbselectBtn.Location = new Point(298, button2.Location.Y);
            pbBorderTop.Location = new Point(0, button2.Location.Y);
            pbBorderBottom.Location = new Point(0, button2.Location.Y + button2.Height);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;
            UserControlTrangCaNhan td = new UserControlTrangCaNhan();
            flowLayoutPanel1.Controls.Add(td);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pbselectBtn.Location = new Point(298, button7.Location.Y);
            pbBorderTop.Location = new Point(0, button7.Location.Y);
            pbBorderBottom.Location = new Point(0, button7.Location.Y + button7.Height);
            Admin ins = new Admin();
            this.Hide();
            ins.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pbselectBtn.Location = new Point(298, button8.Location.Y);
            pbBorderTop.Location = new Point(0, button8.Location.Y);
            pbBorderBottom.Location = new Point(0, button8.Location.Y + button8.Height);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Visible = true;
            wbMap.Visible = false;
            UserControlTinhDiem td = new UserControlTinhDiem();
            flowLayoutPanel1.Controls.Add(td);
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (type == 0)
            {
                button7.Visible = false;
            }
            flowLayoutPanel1.Visible = false;
            panel1.Visible = true;
            wbMap.Visible = true;
            wbMap.Navigate("http://maps.google.com/maps?q=");
            buttonMapSearch.BackgroundImage = Image.FromFile("Images/map.png");
            buttonMapSearch.BackColor = Color.Transparent;
            buttonTimChu.BackColor = Color.Transparent;
            buttonTimChu.BackgroundImage = Image.FromFile("Images/search.png");
        }

        public void MainScreen_Load1()
        {
            if (DiaChiCanDen != null)
            {
                flowLayoutPanel1.Visible = false;
                panel1.Visible = true;
                wbMap.Visible = true;
                string url = Uri.EscapeDataString(DiaChiCanDen);
                wbMap.Navigate("http://maps.google.com/maps?q=" + url);
                buttonMapSearch.BackgroundImage = Image.FromFile("Images/map.png");
                DiaChiCanDen = null;
            }


            buttonMapSearch.BackColor = Color.Transparent;
            buttonTimChu.BackColor = Color.Transparent;
            buttonTimChu.BackgroundImage = Image.FromFile("Images/search.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Khi ấn vào tất cả các trường
            HienTruong = true;
            HienDiem = false;
            HienNganh = false;
            HienToHopMon = false;

            pbselectBtn.Location = new Point(298, button5.Location.Y);
            pbBorderTop.Location = new Point(0, button5.Location.Y);
            pbBorderBottom.Location = new Point(0, button5.Location.Y + button5.Height);

            wbMap.Visible = false;
            flowLayoutPanel1.Visible = true;
            DataTable dt = new DataTable();
            dt = TruongDAO.Instance.GetListTruong();
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                UserControlTruong t = new UserControlTruong();
                t.TenTruong = row[1].ToString();
                t.AnhTruong = row[7].ToString();
                t.MinMaxDiem = CTNganhHocDAO.Instance.getDiemMinMaxFromMaTruong(row[0].ToString());
                flowLayoutPanel1.Controls.Add(t);
            }
        }

        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.Text == "Trường")
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
                foreach (DataRow row in dt.Rows)
                {
                    UserControlTruong t = new UserControlTruong();
                    t.TenTruong = row[1].ToString();
                    t.AnhTruong = row[7].ToString();
                    t.MinMaxDiem = CTNganhHocDAO.Instance.getDiemMinMaxFromMaTruong(row[0].ToString());
                    flowLayoutPanel1.Controls.Add(t);
                }
            }
            else if (comboBoxFilter.Text == "Ngành")
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
                    n.TenNganh = row[1].ToString();
                    n.MaNganh = (int)row[0];

                    flowLayoutPanel1.Controls.Add(n);
                }
            }
            else if (comboBoxFilter.Text == "Tổ hợp môn")
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
            else if (comboBoxFilter.Text == "Điểm chuẩn")
            {
                HienTruong = false;
                HienDiem = true;
                HienNganh = false;
                HienToHopMon = false;

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Visible = true;
                wbMap.Visible = false;

                for (int i = 0; i <= 2; i++)
                {
                    UserControlDiem t = new UserControlDiem();
                    t.From = 15 + 5 * i;
                    t.To = 20 + 5 * i;
                    flowLayoutPanel1.Controls.Add(t);
                }
            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(105, 105, 105);
        }
    }
}
