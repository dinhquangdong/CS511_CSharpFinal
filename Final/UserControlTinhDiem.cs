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
    public partial class UserControlTinhDiem : UserControl
    {
        public UserControlTinhDiem()
        {
            InitializeComponent();
        }

        private void UserControlTinhDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ToHopMonDAO.Instance.GetListTHM();
            List<string> listTHM = new List<string>();
            foreach (DataRow d in dt.Rows)
            {
                listTHM.Add(d[0].ToString());
            }
            comboBoxSelect.Items.Clear();
            comboBoxSelect.DataSource = listTHM;
            comboBoxSelect.DisplayMember = "Name";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txbToan.Text == "") txbToan.Text = "0";
            if (txbLy.Text == "") txbLy.Text = "0";
            if (txbHoa.Text == "") txbHoa.Text = "0";
            if (txbAnhVan.Text == "") txbAnhVan.Text = "0";
            if (txbSinh.Text == "") txbSinh.Text = "0";
            if (txbSu.Text == "") txbSu.Text = "0";
            if (txbDia.Text == "") txbDia.Text = "0";
            if (txbNguVan.Text == "") txbNguVan.Text = "0";
            if (txbHinhHoa.Text == "") txbHinhHoa.Text = "0";
            if (txbBoCuc.Text == "") txbBoCuc.Text = "0";
            if (txbGDCD.Text == "") txbGDCD.Text = "0";
            if (txbNK.Text == "") txbNK.Text = "0";

            switch (comboBoxSelect.Text)
            {
                case "A00":
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A01": //tla
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A02": //tls
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B00": //ths
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B01": //tSinhsu
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B02": //tsinhdia
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C00": //vansusia
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C01": //vantoanli
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C02": //vantoanhoa
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C03": //vantoansu
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D01": //vantoananh
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D07": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbAnhVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "H00": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbHinhHoa.Text) + float.Parse(txbBoCuc.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T00": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T03": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T04": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbLy.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T05": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbGDCD.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T06": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbDia.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
            }
            float A00;
            float A01;
            float A02;
            float B00;
            float B01;
            float B02;
            float C00;
            float C01;
            float C02;
            float C03;
            float D07;
            float D01;
            float H00;
            float T00;
            float T03;
            float T04;
            float T05;
            float T06;

            A00 = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text));
            A01 = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text));
            A02 = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text));
            B00 = (float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text));
            B01 = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text));
            B02 = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text));
            C00 = (float.Parse(txbNguVan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text));
            C01 = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbDiemCong.Text));
            C02 = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text));
            C03 = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text));
            D01 = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text));
            D07 = (float.Parse(txbAnhVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text));
            H00 = (float.Parse(txbNguVan.Text) + float.Parse(txbHinhHoa.Text) + float.Parse(txbBoCuc.Text) + float.Parse(txbDiemCong.Text));
            T00 = (float.Parse(txbSinh.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text));
            T03 = (float.Parse(txbSinh.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text));
            T04 = (float.Parse(txbLy.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text));
            T05 = (float.Parse(txbGDCD.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text));
            T06= (float.Parse(txbDia.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text));




            AccountDAO.Instance.UpdateAccount(MainScreen.instance.Gmail,
                A00,
                A01,
                A02,
                B00,
                B01,
                B02,
                C00,
                C01,
                C02,
                C03,
                D01,
                D07,
                H00,
                T00,
                T03,
                T04,
                T05,
                T06
                );

            flpnDSKQTHK.Controls.Clear();
            string[] MaTHM = { "A00", "A01", "A02", "B00", "B01", "B02", "C00", "C01", "C02", "C03", "D01", "D07", "H00", "T00", "T03", "T04", "T05", "T06" };
            string[] TenTHM = { "Toán, Lý, Hóa", "Toán, Lý, Anh", "Toán, Lý, Sinh","Toán, Hóa, Sinh","Toán, Sinh, Sử","Toán, Sinh, Địa","Văn, Sử, Địa","Văn, Toán, Lí","Văn, Toán, Hóa","Văn, Toán, Sử","Văn, Toán, Anh","Toán, Hóa, Anh","Văn, Hình họa, Bố cục tranh màu","Toán, Sinh, NK TDTT","Văn, Sinh, NK TDTT","Toán, Lý, NK TDTT","Văn, GDCD, NK TDTT","Toán, Địa, NK TDTT" };
            float[] DiemTHM = { A00, A01, A02, B00, B01, B02, C00, C01, C02, C03, D01, D07, H00, T00, T03, T04, T05, T06 };
            for(int i = 0; i< 18; i++)
            {
                UserControlKetQuaDiemTHM us = new UserControlKetQuaDiemTHM();
                us.MaTHM = MaTHM[i];
                us.TenTHM = TenTHM[i];
                us.DiemTHM = DiemTHM[i];
                flpnDSKQTHK.Controls.Add(us);
            }
            
            
            


            

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(66,166,244);
            pictureBox1.BackgroundImage = Image.FromFile("./Images/result_2.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Image.FromFile("./Images/result_.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControlGoiYNganh gyn = new UserControlGoiYNganh();
            MainScreen.instance.flowLayoutPanel1.Controls.Add(gyn);

        }
    }
}
