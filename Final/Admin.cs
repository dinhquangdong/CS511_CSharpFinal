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

        }
        void addToHopMonBinding()
        {

        }
        void addCTNganhBinding()
        {

        }
        void addCTTHMBinding()
        {

        }
        void addAccountBinding()
        {

        }

    }
}
