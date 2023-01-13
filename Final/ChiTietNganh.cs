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
    public partial class ChiTietNganh : Form
    {
        public static ChiTietNganh instance;
        public DataTable ThongTinNganh;
        public int MaNganh;

        public ChiTietNganh()
        {
            InitializeComponent();
            instance = this;
        }
        
        private void ChiTietNganh_Load(object sender, EventArgs e)
        {
            DataRow r = ThongTinNganh.Rows[0];
            labelMaNganh.Text = "Mã ngành: " + r[0].ToString();
            labelTenNganh.Text = r[1].ToString();
            richTextBoxGioiThieuNganh.Text = r[2].ToString();
            pictureBox1.BackgroundImage = Image.FromFile("Images/" + r[3].ToString());

            label2.Text = $"Các trường có ngành {r[1].ToString()}:";
            dataGridViewDanhSachCacTruongCoNganh.Controls.Clear();
            dataGridViewDanhSachCacTruongCoNganh.DataSource = CTNganhHocDAO.Instance.GetListTruongFromMaNganh(int.Parse(r[0].ToString()));


            LoadDanhGia(int.Parse(r[0].ToString()));
        }

        public void reLoad()
        {
            LoadDanhGia(MaNganh);
        }

        void LoadDanhGia(int manganh)
        {
            flpnDanhGia.Controls.Clear();
            UserControlAddBinhLuan abl = new UserControlAddBinhLuan();
            flpnDanhGia.Controls.Add(abl);
            DataTable dt = new DataTable();
            dt = BinhLuanNganhDAO.Instance.getListDanhGiaFromMaNganh(manganh);
            labelSoLuotBL.Text = dt.Rows.Count.ToString();

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
                string time = thoigian.ToString("HH:mm:ss tt");
                dg.ThoiGianBL = time;

                flpnDanhGia.Controls.Add(dg);
            }
        }
    }
}
