using Final.DAO;
using Final.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Admin : Form
    {
        BindingSource truonglist = new BindingSource();
        BindingSource nganhtlist = new BindingSource();
        BindingSource tohopmonlist = new BindingSource();
        BindingSource ctnganhlist = new BindingSource();
        BindingSource ctthmlist = new BindingSource();
        BindingSource accountlist = new BindingSource();

        public Account LoginAccount;

        public Admin()
        {
            InitializeComponent();
            Load_();
        }

        void Load_()
        {
            dtgvDanhSachTruong.DataSource = truonglist;
            dtgvDanhSachNganh.DataSource = nganhtlist;
            dtgvDanhSachToHopMon.DataSource = tohopmonlist;
            dtgvCTTHM.DataSource = ctthmlist;
            dtgvDanhSachCTNganh.DataSource = ctnganhlist;
            dtgvDanhSachTaiKhoang.DataSource = accountlist;

            loadlistTruong();
            loadlistNganh();
            loadlistToHopMon();
            loadlistCTNganh();
            loadlistCTTHM();
            loadlistAccount();

            addTruongBinding();
            addNganhBinding();
            addAccountBinding();
            addToHopMonBinding();
            addCTNganhBinding();
            addCTTHMBinding();
        }

        void loadlistTruong()
        {
            truonglist.DataSource = TruongDAO.Instance.GetListTruong();
        }
        void loadlistNganh()
        {
            nganhtlist.DataSource =  NganhDAO.Instance.GetListNganh();
        }
        void loadlistToHopMon()
        {
            tohopmonlist.DataSource = ToHopMonDAO.Instance.GetListTHM();
        }
        void loadlistCTTHM()
        {
            ctthmlist.DataSource = CTToHopMonDAO.Instance.GetListCTToHopMon();
        }
        void loadlistCTNganh()
        {
            ctnganhlist.DataSource = CTNganhHocDAO.Instance.GetListCTNganh();
        }
        void loadlistAccount()
        {
            accountlist.DataSource = AccountDAO.Instance.GetListAccount();
        }
        
        void addTruongBinding()
        {
            txbTenTruong.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "TenTruong");
            txbMaTruong.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "MaTruong");
            txbLink.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "LinkWebTruong");
            txbDiaChi.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "DiaChi");
            txbSDT.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "SDT");
            txbSaoDanhGia.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "SaoDanhGia");
            txbReview.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "ReView");
            txbAnhTruong.DataBindings.Add("Text", dtgvDanhSachTruong.DataSource, "AnhTruong");
        }
        void addNganhBinding()
        {
            txbMaNganh.DataBindings.Add("Text", dtgvDanhSachNganh.DataSource, "MaNganh");
            txbTenNganh.DataBindings.Add("Text", dtgvDanhSachNganh.DataSource, "TenNganh");
        }
        void addToHopMonBinding()
        {
            txbMaToHopMon.DataBindings.Add("Text", dtgvDanhSachToHopMon.DataSource, "MaToHopMon");
            txbTenCacToHop.DataBindings.Add("Text", dtgvDanhSachToHopMon.DataSource, "TenMonHoc");
        }
        void addCTNganhBinding()
        {
            txbMaNganhCT_NH.DataBindings.Add("Text", dtgvDanhSachCTNganh.DataSource, "MaNganh");
            txbMaTruongCT_NH.DataBindings.Add("Text", dtgvDanhSachCTNganh.DataSource, "MaTruong");
            txbDiemChuanCT_NH.DataBindings.Add("Text", dtgvDanhSachCTNganh.DataSource, "DiemChuan");
        }
        void addCTTHMBinding()
        {
            txbMaNganhCT_THM.DataBindings.Add("Text", dtgvCTTHM.DataSource, "MaNganh");
            txbMaToHopMonCT_THM.DataBindings.Add("Text", dtgvCTTHM.DataSource, "MaToHopMon");
        }
        void addAccountBinding()
        {
            txbIdNguoiDung.DataBindings.Add("Text", dtgvDanhSachTaiKhoang.DataSource, "Id");
            txbTenNguoiDung.DataBindings.Add("Text", dtgvDanhSachTaiKhoang.DataSource, "UserName");
            txbTenHienThi.DataBindings.Add("Text", dtgvDanhSachTaiKhoang.DataSource, "DisplayName");
            txbGioiTinh.DataBindings.Add("Text", dtgvDanhSachTaiKhoang.DataSource, "Gender");
            txbLoaiTK.DataBindings.Add("Text", dtgvDanhSachTaiKhoang.DataSource, "Type");
        }

        
        List<Truong> SearchListTruongByTenOrMaTruong(string name)
        {
            List<Truong> truongs = TruongDAO.Instance.SearchListTruongbyByTenOrMaTruong(name);
            return truongs;
        }

        private void btnTimTruong_Click(object sender, EventArgs e)
        {
            truonglist.DataSource = SearchListTruongByTenOrMaTruong(txbTimTruong.Text);
        }

        private void btnThemTruong_Click(object sender, EventArgs e)
        {
            if (TruongDAO.Instance.ThemTruong(txbMaTruong.Text, txbTenTruong.Text, txbLink.Text, txbDiaChi.Text, txbSDT.Text, float.Parse(txbSaoDanhGia.Text, CultureInfo.InvariantCulture.NumberFormat), txbReview.Text, txbAnhTruong.Text))
            {
                MessageBox.Show("Thêm trường thành công");
            }
            else
            {
                MessageBox.Show("Thêm trường thất bại");
            }
        }
        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            if(NganhDAO.Instance.ThemNganh(int.Parse(txbMaNganh.Text), txbTenNganh.Text))
            {
                MessageBox.Show("Thêm ngành thành công");
            }
            else
            {
                MessageBox.Show("Thêm ngành thất bại");
            }    
        }

        private void btnThemToHopMon_Click(object sender, EventArgs e)
        {
            if (ToHopMonDAO.Instance.ThemToHopMon(txbMaToHopMon.Text, txbTenCacToHop.Text))
            {
                MessageBox.Show("Thêm tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Thêm tổ hợp môn thất bại");
            }
        }

        private void btnThemCTNganh_Click(object sender, EventArgs e)
        {
            if (CTNganhHocDAO.Instance.ThemChiTietNganh(txbMaTruongCT_NH.Text, int.Parse(txbMaNganhCT_NH.Text), float.Parse(txbDiemChuanCT_NH.Text, CultureInfo.InvariantCulture.NumberFormat)))
            {
                MessageBox.Show("Thêm chi tiết ngành thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết ngành thất bại");
            }
        }

        private void btnThemCTTHM_Click(object sender, EventArgs e)
        {
            if (CTToHopMonDAO.Instance.ThemChiTietToHopMon(int.Parse(txbMaNganhCT_THM.Text), txbMaToHopMonCT_THM.Text))
            {
                MessageBox.Show("Thêm chi tiết tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Thêm chi tiết tổ hợp môn thất bại");
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.ThemTaiKhoan(int.Parse(txbIdNguoiDung.Text), txbTenNguoiDung.Text, txbTenHienThi.Text, txbGioiTinh.Text, int.Parse(txbLoaiTK.Text)))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }

        List<Nganh> SearchListNganhByTenOrMaNganh(string name)
        {
            List<Nganh> nganhs = NganhDAO.Instance.SearchListNganhbyByTenOrMaNganh(name);
            return nganhs;
        }

        private void btnTimNganh_Click(object sender, EventArgs e)
        {
            nganhtlist.DataSource = SearchListNganhByTenOrMaNganh(txbTimNganh.Text);
        }

        List<ToHopMon> SearchListToHopMonByTenOrMaTHM(string name)
        {
            List<ToHopMon> thms = ToHopMonDAO.Instance.SearchListTHMhbyByTenOrMaTHM(name);
            return thms;
        }

        private void btnTimToHopMon_Click(object sender, EventArgs e)
        {
            tohopmonlist.DataSource = SearchListToHopMonByTenOrMaTHM(txbTimToHopMon.Text);
        }

        List<CTToHopMon> SearchListCTTHMbyByMaTHMOrMaNganh(string name)
        {
            List<CTToHopMon> thms = CTToHopMonDAO.Instance.SearchListCTTHMbyByMaTHMOrMaNganh(name);
            return thms;
        }

        List<CTNganhHoc> SearchListCTNganhbyByMaTruongOrMaNganh(string name)
        {
            List<CTNganhHoc> thms = CTNganhHocDAO.Instance.SearchListCTNganhbyByMaTruongOrMaNganh(name);
            return thms;
        }

        List<Account> SearchListAccountbyByUserOrDisplayName(string name)
        {
            List<Account> thms = AccountDAO.Instance.SearchListAccountbyByUserOrDisplayName(name);
            return thms;
        }

        private void btnTimCTNganh_Click(object sender, EventArgs e)
        {
            ctnganhlist.DataSource = SearchListCTNganhbyByMaTruongOrMaNganh(txbTimCTNganh.Text);
        }

        private void btnTimCTTHM_Click(object sender, EventArgs e)
        {
            ctthmlist.DataSource = SearchListCTTHMbyByMaTHMOrMaNganh(txbTimCTTHM.Text);
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {
            accountlist.DataSource = SearchListAccountbyByUserOrDisplayName(txbTimTK.Text);
        }

        private void btnXoaTruong_Click(object sender, EventArgs e)
        {
            if (TruongDAO.Instance.deleteTruongFromMaOrTen(txbMaTruong.Text, txbTenTruong.Text))
            {
                MessageBox.Show("Xoá trường thành công");
            }
            else
            {
                MessageBox.Show("Xoá trường thất bại");
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            if (NganhDAO.Instance.deleteNganhFromMaOrTen(txbMaNganh.Text, txbTenNganh.Text))
            {
                MessageBox.Show("Xoá ngành thành công");
            }
            else
            {
                MessageBox.Show("Xoá ngành thất bại");
            }
        }

        private void btnXoaToHopMon_Click(object sender, EventArgs e)
        {
            if (ToHopMonDAO.Instance.deleteToHopFromMaOrTen(txbMaToHopMon.Text, txbTenCacToHop.Text))
            {
                MessageBox.Show("Xoá tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Xoá tổ hợp môn thất bại");
            }
        }

        private void btnXoaCTNganh_Click(object sender, EventArgs e)
        {
            if (CTNganhHocDAO.Instance.deleteCTNganhFromMaTruongAndMaNghanh(txbMaTruongCT_NH.Text, txbMaNganhCT_NH.Text))
            {
                MessageBox.Show("Xoá chi tiết ngành thành công");
            }
            else
            {
                MessageBox.Show("Xoá chi tiết ngành thất bại");
            }
        }

        private void btnXoaCTTHM_Click(object sender, EventArgs e)
        {
            if (CTToHopMonDAO.Instance.deleteCTToHopMonFromMaNghanhAndMaToHopMon(txbMaNganhCT_THM.Text, txbMaToHopMonCT_THM.Text))
            {
                MessageBox.Show("Xoá chi tiết tổ hợp môn thành công");
            }
            else
            {
                MessageBox.Show("Xoá chi tiết tổ hợp môn thất bại");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.DeleteAccountFromId(int.Parse(txbIdNguoiDung.Text)))
            {
                MessageBox.Show("Xoá người dùng thành công");
            }
            else
            {
                MessageBox.Show("Xoá người dùng thất bại");
            }
        }

        private void btnSuaTruong_Click(object sender, EventArgs e)
        {
            loadlistTruong();
        }

        private void btnSuaNganh_Click(object sender, EventArgs e)
        {
            loadlistNganh();
        }

        private void btnSuaToHopMon_Click(object sender, EventArgs e)
        {
            loadlistToHopMon();
        }

        private void btnSuaCTNganh_Click(object sender, EventArgs e)
        {
            loadlistCTNganh();
        }

        private void btnSuaCTTHM_Click(object sender, EventArgs e)
        {
            loadlistCTTHM();
        }
    }
}
