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

        private void UserControlDiem_Click(object sender, EventArgs e)
        {
            NganhTheoDiem ntd = new NganhTheoDiem();
            ntd.From = From;
            ntd.To = To;
            ntd.ShowDialog();
        }

        private void UserControlDiem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            labelFrom.ForeColor = Color.FromArgb(66, 133, 244);
            labelTo.ForeColor = Color.FromArgb(66, 133, 244);
            pictureBox1.BackColor = Color.FromArgb(66, 133, 244);
        }

        private void UserControlDiem_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(66, 133, 244);
            labelFrom.ForeColor = Color.White;
            labelTo.ForeColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        public UserControlDiem()
        {
            InitializeComponent();
            
        }
    }
}
