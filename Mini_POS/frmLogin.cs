using Bll;
using Bll.Utilities;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_POS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string linkUrl = @"https://ayham.online";
            System.Diagnostics.Process.Start(linkUrl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            User_DTO loginUserRestult = await clsUser.LoginAsync(username, password);

            if (loginUserRestult != null)
            {
                if (cbRememberMe.Checked)
                    clsUtilities.SaveCredentialsToRegistry(username, password);
                else
                    clsUtilities.ClearCredentialsFromRegistry();

                clsGlobal.CurrentUser = loginUserRestult;

                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
                this.frmLogin_Load(null, null);
                this.Show();

            }
            else
            {
                MessageBox.Show("Check if invalid username or password or the account is not active.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _ResetForm()
        {
            tbPassword.Clear();
            tbUsername.Clear();
            cbRememberMe.Checked = false;
            tbUsername.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = null;
            string password = null;
            
            if(clsUtilities.GetCredentialsFromRegistry(out username , out password))
            {
                tbUsername.Text = username;
                tbPassword.Text = password;
                cbRememberMe.Checked = true;
            }
            else
            {
                _ResetForm();
            }
        }
    }
}
