using System;
using System.Net;
using System.Net.Mail;
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

                string to = "sam@sam4it.com";
                string from = "software@multidesk.com";
                MailMessage message = new MailMessage(from, to);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 465;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("samuelbancroft@gmail.com", "fqm1729ARB3f5D!");
                message.Subject = "Contact from multidesk user " + userName;
                message.Body = messageContents;
                client.Send(message);
                Close();
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
