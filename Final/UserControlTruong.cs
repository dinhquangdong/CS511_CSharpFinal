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
    public partial class UserControlTruong : UserControl
    {
        public static UserControlTruong Instance;
        public string TenTruong;
        public string AnhTruong;
        public UserControlTruong()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UserControlTruong_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("Images/" + AnhTruong);
            labelName.Text = TenTruong;
        }
    }
}
