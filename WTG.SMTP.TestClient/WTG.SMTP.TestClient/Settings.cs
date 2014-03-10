using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTG.SMTP.TestClient
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            txtSetttingsFromEmail.Text =Properties.Settings.Default.FromEmail;
            txtSettingsHost.Text = Properties.Settings.Default.Host;
            txtSettingsPort.Text = Properties.Settings.Default.Port;
            txtSettingsUserName.Text = Properties.Settings.Default.UserName;
            txtSettingsPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetttingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FromEmail = txtSetttingsFromEmail.Text;
            Properties.Settings.Default.Host = txtSettingsHost.Text;
            Properties.Settings.Default.Port = txtSettingsPort.Text;
            Properties.Settings.Default.UserName = txtSettingsUserName.Text;
            Properties.Settings.Default.Password = txtSettingsPassword.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
