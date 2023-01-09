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
            pictureBox1.BackgroundImage = Image.FromFile("./Images/result.png");
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
            switch (comboBoxSelect.Text)
            {
                case "A00":
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A01": //tla
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A02": //tls
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B00": //ths
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B01": //tSinhsu
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B02": //tsinhdia
                    txbKetQua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C00": //vansusia
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C01": //vantoanli
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C02": //vantoanhoa
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C03": //vantoansu
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D01": //vantoananh
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D07": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbAnhVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "H00": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbHinhHoa.Text) + float.Parse(txbBoCuc.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T00": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T03": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T04": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbLy.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T05": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbGDCD.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T06": //toanhoaanh
                    txbKetQua.Text = (float.Parse(txbDia.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
            }
        }
    }
}
