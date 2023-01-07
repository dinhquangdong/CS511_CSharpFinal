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
    public partial class UserControlNganh : UserControl
    {
        public static UserControlNganh Instance;
        public string TenNganh;

        public UserControlNganh()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UserControlNganh_Load(object sender, EventArgs e)
        {
            labelTenNganh.Text = TenNganh;
        }
    }
}
