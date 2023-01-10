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
    public partial class UserControlToHopMon : UserControl
    {
        public static UserControlToHopMon instance;
        public UserControlToHopMon()
        {
            InitializeComponent();
            instance = this;
        }
        public string MaTHM;
        public string TenTHM;
        private void UserControlToHopMon_Load(object sender, EventArgs e)
        {
            labelMa.Text = MaTHM;
            labelMon.Text = TenTHM;
        }

        private void UserControlToHopMon_Click(object sender, EventArgs e)
        {
            MainScreen.instance.HienTruong = false;
            MainScreen.instance.HienDiem = false;
            MainScreen.instance.HienNganh = true;
            MainScreen.instance.HienToHopMon = false;

            MainScreen.instance.flowLayoutPanel1.Controls.Clear();
            MainScreen.instance.flowLayoutPanel1.Visible = true;

            DataTable dt = new DataTable();
            dt = NganhDAO.Instance.GetListNganhFromMaTHM(MaTHM);

            foreach (DataRow row in dt.Rows)
            {
                UserControlNganh n = new UserControlNganh();
                n.MaNganh = (int)row[0];
                n.TenNganh = row[1].ToString();

                MainScreen.instance.flowLayoutPanel1.Controls.Add(n);
            }

        }
    }
}
