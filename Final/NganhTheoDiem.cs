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
    public partial class NganhTheoDiem : Form
    {
        public int From, To;
        public NganhTheoDiem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = CTNganhHocDAO.Instance.GetListDiemChuanFromDiem(From, To);
            dataGridView1.Controls.Clear();

            dt.Select("'Tên trường' = '"+comboBox1.Text+"'");
            dataGridView1.DataSource = dt;
        }

        private void NganhTheoDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = CTNganhHocDAO.Instance.GetListDiemChuanFromDiem(From, To);
            dataGridView1.Controls.Clear();
            dataGridView1.DataSource = dt;

            foreach(DataRow dr in dt.Rows )
            {
                if (!comboBox1.Items.Contains(dr[0]))
                    comboBox1.Items.Add(dr[0] );
            }
        }
    }
}
