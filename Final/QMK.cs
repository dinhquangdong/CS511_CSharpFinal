using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Final.DAO;

namespace Final
{
    public partial class QMK : Form
    {
        public QMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string TenUser = txbUsername.Text;
            string email = txbEmail.Text;
            string from = "truongchinh808@gmail.com";
            string password = "3216549870";
            string newPass = "123";
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(from);
            mailMessage.To.Add(email);
            mailMessage.Subject = "Lấy mật khẩu mới";
            mailMessage.Body = $"Mật khẩu mới của bạn là {newPass}";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from,password);
            
            try
            {
                smtpClient.Send(mailMessage);
                AccountDAO.Instance.updatePass(TenUser, password);
                MessageBox.Show("Gửi thành công");

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
