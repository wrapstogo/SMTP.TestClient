using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTG.SMTP.TestClient
{
    public partial class SMTP_TestClient : Form
    {
        public SMTP_TestClient()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            
            if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show(
                   "Please provide a to email",
                   "To address is empty!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                MessageBox.Show(
                   "Please provide a subject",
                   "Subject is empty!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show(
                       "Please provide a text as message",
                       "Message is empty!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtTo.Clear();
            txtMessage.Clear();
            txtSubject.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var val = ValidateInputs();
            if(val)
            {
                using (var client = new SmtpClient())
                {
                    var msg = new MailMessage()
                    {
                        Body = txtMessage.Text,
                        Subject = txtSubject.Text
                    };

                    msg.From = new MailAddress(Properties.Settings.Default.FromEmail);
                    msg.IsBodyHtml = true;
                    msg.To.Add(txtTo.Text);

                    client.Host = Properties.Settings.Default.Host;
                    client.Port = Convert.ToInt32(Properties.Settings.Default.Port);
                    client.Credentials = new NetworkCredential(Properties.Settings.Default.UserName, Properties.Settings.Default.Password);
                    client.EnableSsl = false;

                    try
                    {
                        client.Send(msg);
                    }
                    catch (SmtpException ex)
                    {
                        var exeception = ex.GetBaseException();

                        MessageBox.Show(
                       exeception.Message,
                       "Failed to deliver",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        
                    }
                }

                ClearInputs();

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SMTP_TestClient_Load(object sender, EventArgs e)
        {

        }


    }
}
