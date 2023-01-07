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

namespace mapgoogle
{
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void btnThemTruong_Click(object sender, EventArgs e)
        {
            if (insertTruong())
            {
                MessageBox.Show("Thêm trường thành công");
            }
            else
            {
                MessageBox.Show("Thêm trường THẤT BẠI");
            }
        }

        private void btnThemToHopMon_Click(object sender, EventArgs e)
        {
            if (insertToHopMon())
            {
                MessageBox.Show("Thêm tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Thêm tổ hợp môn THẤT BẠI");
            }
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            if (insertNganh())
            {
                MessageBox.Show("Thêm ngành thành công");
            }
            else
            {
                MessageBox.Show("Thêm ngành THẤT BẠI");
            }
        }

        private void btnThemCTToHopMon_Click(object sender, EventArgs e)
        {
            if (insertCTToHopMon())
            {
                MessageBox.Show("Thêm chi tiết tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết tổ hợp môn THẤT BẠI");
            }
        }

        private void btnCTNganhHoc_Click(object sender, EventArgs e)
        {
            if (insertCTNganh())
            {
                MessageBox.Show("Thêm chi tiết ngành thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết ngành THẤT BẠI");
            }
        }

        public bool insertTruong()
        {
            string MaTruong = txbMaTruong.Text;
            string TenTruong = txbTenTruong.Text;
            string LinkWebTruong = txbLink.Text;
            string DiaChi = txbDiaChi.Text;
            string SDT = txbSDT.Text;
            float SaoDanhGia = float.Parse(txbSaoDanhGia.Text);
            string ReView = txbReview.Text;
            string AnhTruong = txbAnhTruong.Text;
            string query = string.Format("insert into TRUONG values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5},N'{6}',N'{7}')",
                MaTruong, TenTruong, LinkWebTruong, DiaChi, SDT, SaoDanhGia, ReView, AnhTruong);
            int results = 0;
            try
            {
                results = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch{}
            return results > 0;
        }
        public bool insertToHopMon()
        {
            string MaToHopMon = txbMaToHopMon.Text;
            string TenToHopMon = txbTenCacToHop.Text;
            string query = string.Format("insert into TOHOPMON values (N'{0}',N'{1}')",
                MaToHopMon, TenToHopMon);
            int results = 0;
            try
            {
                results = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch { }
            return results > 0;
        }
        public bool insertNganh()
        {
            int MaNganh = int.Parse(txbMaNganh.Text);
            string TenNganh = txbTenNganh.Text;
            string query = string.Format("insert into NGANHHOC values ({0},N'{1}')",
                MaNganh, TenNganh);
            int results = 0;
            try
            {
                results = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch { }
            return results > 0;
        }
        public bool insertCTNganh()
        {
            string MaTruong = (txbMaTruongCT_NH.Text);
            int MaNganh = int.Parse(txbMaNganhCT_NH.Text);
            float DiemChuan = float.Parse(txbDiemChuanCT_NH.Text);
            string query = string.Format("insert into CTNGANHHOC values (N'{0}',{1},{2})",
                MaTruong, MaNganh, DiemChuan);
            int results = 0;
            try
            {
                results = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch { }
            return results > 0;
        }

        public bool insertCTToHopMon()
        {
            int MaNganh = int.Parse(txbMaNganhCT_THM.Text);
            string MaToHopMon = txbMaToHopMonCT_THM.Text;
            string query = string.Format("insert into CTTOHOPMON values ({0},N'{1}')",
                 MaNganh, MaToHopMon);
            int results = 0;
            try
            {
                results = DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch { }
            return results > 0;
        }
    }
}
