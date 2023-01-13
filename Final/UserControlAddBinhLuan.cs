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
    public partial class UserControlAddBinhLuan : UserControl
    {
        int saodg;
        public UserControlAddBinhLuan()
        {
            InitializeComponent();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd.Checked)
            {
                saodg =int.Parse(rd.Tag.ToString());
            }
        }

        private void btnBinhLuan_Click(object sender, EventArgs e)
        {
            if (MainScreen.instance.BLNganh == false)
            {
                BinhLuanTruongDAO.Instance.insertBinhLuan(ChiTietTruong.instance.MaTruong, MainScreen.instance.Gmail, txbBinhLuan.Text, saodg);
                ChiTietTruong.instance.reLoad();
            }
            else
            {
                BinhLuanNganhDAO.Instance.insertBinhLuan(ChiTietNganh.instance.MaNganh, MainScreen.instance.Gmail, txbBinhLuan.Text, saodg);
                ChiTietNganh.instance.reLoad();
            }
        }
    }
}
