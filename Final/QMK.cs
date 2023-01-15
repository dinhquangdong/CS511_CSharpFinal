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

        public static string GetRandomPassword(int length = 5)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string TenUser = txbUsername.Text;
            string email = txbEmail.Text;
            string from = "20521137@gm.uit.edu.vn";
            string password = "vanch";
            string newPass = GetRandomPassword();
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
                AccountDAO.Instance.updatePass(TenUser, newPass);
                MessageBox.Show("Gửi thành công");

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
