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
    public partial class UserControlKetQuaDiemTHM : UserControl
    {
        public string MaTHM;
        public string TenTHM;
        public float DiemTHM;
        public UserControlKetQuaDiemTHM()
        {
            InitializeComponent();
        }

        private void UserControlKetQuaDiemTHM_Load(object sender, EventArgs e)
        {
            lbMaTHM.Text = MaTHM;
            lbTenTHM.Text = TenTHM;
            lbDiemTHM.Text = DiemTHM.ToString();
        }

        private void UserControlKetQuaDiemTHM_Click(object sender, EventArgs e)
        {

        }
    }
}
