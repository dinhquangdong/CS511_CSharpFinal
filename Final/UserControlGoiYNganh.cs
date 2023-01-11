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
    public partial class UserControlGoiYNganh : UserControl
    {
        public UserControlGoiYNganh()
        {
            InitializeComponent();
        }

        private void UserControlGoiYNganh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = AccountDAO.Instance.GetListDiemFromGmail(MainScreen.instance.Gmail);

            DataTable dt3 = new DataTable();
            float diem = 0;
            DataRow r = dt.Rows[0];
            diem = float.Parse(r[dt.Columns.IndexOf(comboBox1.Text)].ToString());
            dt3 = CTNganhHocDAO.Instance.GetListNganhTruongDiemChuanFromMaToHopMonvaDiem(comboBox1.Text, diem);

            DataTable dt2 = new DataTable();
            dt2 = ToHopMonDAO.Instance.GetListTHM();
            List<string> listTHM = new List<string>();
            foreach (DataRow d in dt2.Rows)
            {
                listTHM.Add(d[0].ToString());
            }
            comboBox1.Items.Clear();
            comboBox1.DataSource = listTHM;
            comboBox1.DisplayMember = "Name";
        }
    }
}
