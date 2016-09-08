using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class frmNameInput : Form
    {
        public frmNameInput()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMessage.Text != "")
            {
                string userName = txtName.Text;
                string messageContents = txtMessage.Text;
                string password = "fqm1729ARB3f5D!";
                var to = new MailAddress("samuelbancroft@gmail.com", "Automated");
                var from = new MailAddress("software@multidesk.com", "Automated");               
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,                 
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(from.Address, password)
                };
                using (var message = new MailMessage(from, to)
                {
                    Subject = "Automatic message from MultiDesk user",
                    Body = userName + " " + messageContents
                })
                {
                    smtp.Send(message);
                }


                /*MailMessage message = new MailMessage(from, to);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 465;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("samuelbancroft@gmail.com", "fqm1729ARB3f5D!");
                message.Subject = "Contact from multidesk user " + userName;
                message.Body = messageContents;
                client.Send(message);
                Close();*/
            }
            else
            {
                MessageBox.Show(@"Please enter both your name and message", @"Fill all fields", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
