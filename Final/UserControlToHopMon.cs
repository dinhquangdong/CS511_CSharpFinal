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
    }
}
