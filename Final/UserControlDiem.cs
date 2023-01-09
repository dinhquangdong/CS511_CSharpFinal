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
    public partial class UserControlDiem : UserControl
    {
        public int From, To;

        private void UserControlDiem_Load(object sender, EventArgs e)
        {
            labelFrom.Text = From.ToString();
            labelTo.Text = To.ToString();
        }

        public UserControlDiem()
        {
            InitializeComponent();
            
        }
    }
}
