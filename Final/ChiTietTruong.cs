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
    public partial class ChiTietTruong : Form
    {
        public static ChiTietTruong instance;
        //private string MaTruong, TenTruong, LinkWebTruong, DiaChi, SDT, Review;
        //private Image AnhTruong;
        //private float DanhGia;
        public DataTable ThongTinTruong;
        public string MaTruong;

        public ChiTietTruong()
        {
            InitializeComponent();
            instance = this;
        }

        public void ChiTietTruong_Load(object sender, EventArgs e)
        {
            DataRow r = ThongTinTruong.Rows[0];
            labelMaTruong.Text = "Mã trường: " + r[0].ToString();
            labelTenTruong.Text = r[1].ToString();
            linkLabel.Text = r[2].ToString();
            labelDiaChi.Text = "Địa chỉ: " + r[3].ToString();
            labelSoDienThoai.Text = "Điện thoại: " + r[4].ToString();
            labelSaoDanhGia.Text = "Đánh giá: " + r[5].ToString() + "/5";
            richTextBox1.Text = r[6].ToString();
            pictureBoxLogo.BackgroundImage = Image.FromFile("Images/" + r[7].ToString());
            
            dataGridView1.Controls.Clear();
            dataGridView1.DataSource = NganhDAO.Instance.GetListNganhFromMaTruong(r[0].ToString());
            LoadDanhGia(r[0].ToString());
            MaTruong = r[0].ToString();
        }

        public void reLoad()
        {
            LoadDanhGia(MaTruong);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DiaChi = ThongTinTruong.Rows[0][3].ToString();
            string TenTruong = ThongTinTruong.Rows[0][1].ToString();
            MainScreen.instance.DiaChiCanDen = TenTruong + " , " + DiaChi;

            this.Close();
        }

        void LoadDanhGia(string matruong)
        {
            flpnDanhGia.Controls.Clear();
            UserControlAddBinhLuan abl = new UserControlAddBinhLuan();
            flpnDanhGia.Controls.Add(abl);
            DataTable dt = new DataTable();
            dt = BinhLuanTruongDAO.Instance.getListDanhGiaFromMaTruong(matruong);
            lbSoLuotBL.Text = dt.Rows.Count.ToString();
            foreach (DataRow r in dt.Rows)
            {
                string displayname = AccountDAO.Instance.getDisplayNameByGmail(r[2].ToString());
                string sosao = r[4].ToString();
                string binhluan = r[3].ToString();
                DateTime thoigian = (DateTime)Convert.ToDateTime(r[5]);
                UserControlDanhGia dg = new UserControlDanhGia();
                dg.TenHienThi = displayname;
                dg.SoSao = sosao;
                dg.LoiNhanXet = binhluan;
                int time = (DateTime.Now.TimeOfDay.Hours - thoigian.TimeOfDay.Hours);
                if(time <= 24)
                {
                    dg.LoaiTG = "giờ trước";
                    dg.ThoiGianBL = time.ToString();
                }
                else
                {
                    dg.ThoiGianBL = (DateTime.Now.DayOfYear - thoigian.DayOfYear).ToString();
                    dg.LoaiTG = "ngày trước";
                }
                flpnDanhGia.Controls.Add(dg);
            }
        }

    }
}
