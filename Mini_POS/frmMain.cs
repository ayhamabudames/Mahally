using Bll.Utilities;
using Mini_POS.Navigation;
using Mini_POS.Utilities;
using MyCustomControls;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            PUtilities.MainFormInstance = this;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _InitiFormData();

        }

        private void _InitiFormData()
        {
            // Set the current user information on the form
            lblLogednnUserFullName.Text = clsGlobal.CurrentUser.Name;
            lblLogedInUserRole.Text = clsGlobal.CurrentUser.RoleInfo.ToString();

            //set navigation permission
            if (clsGlobal.CurrentUser.RoleInfo == DTO.User_DTO.enRole.Cashier)
            {
                btnUsers.Visible = false;
                btnDahsboard.Visible = false;
            }

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsUtilities.ClearCredentialsFromRegistry();
            this.Close();
        }

        private void _HighlightButton(AyhamButton sender)
        {
            AyhamButton[] sideButtons = { btnHome, btnProducts, btnDahsboard, btnUsers, btnSettings };
            foreach (AyhamButton b in sideButtons)
            {
                b.ButtonStyle = AyhamButton.enButtonStyle.AcceptOutline;
            }
            sender.ButtonStyle = AyhamButton.enButtonStyle.Accept;
        }

        private void _NavigatePage(AyhamButton sender)
        {
            Control _currentNav = null;

            Control temp = _currentNav = this.Controls.Find("ucCurrentNav", true).FirstOrDefault();
            switch (sender.Tag)
            {
                case "dashboard":
                    temp = new ucDashboardNav();
                    break;
                case "products":
                    temp = new ucProductsNav();
                    break;
                case "users":
                    temp = new ucUsersNav();
                    break;
                case "settings":
                    temp = new ucSettingsNav();
                    break;

                default:
                    temp = new ucHomeNav();
                    break;
            }

            this.Controls.Remove(_currentNav);
            _currentNav = temp;
            _currentNav.Name = "ucCurrentNav";
            _currentNav.Location = new Point(326, 29);
            this.Controls.Add(_currentNav);
            _currentNav = this.Controls.Find("ucCurrentNav", true).FirstOrDefault();
        }

        private void _Navigate(AyhamButton sender)
        {
            _HighlightButton(sender);
            _NavigatePage(sender);
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            _Navigate((AyhamButton)sender);
        }

        private void btnDahsboard_Click(object sender, EventArgs e)
        {
            _Navigate((AyhamButton)sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            _Navigate((AyhamButton)sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _Navigate((AyhamButton)sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _Navigate((AyhamButton)sender);
        }

        private void ucCurrentNav_Load(object sender, EventArgs e)
        {
        }
    
        public async void ShowNotification(string title, string content, float seconds,bool red = false)
        {
            lblTitleNoti.Text = title;
            lblContentNoti.Text = content;
            pnlNotification.BorderColor = (red) ? Color.FromArgb(239, 68, 68) : Color.FromArgb(16, 185, 129);
            
            pnlNotification.Visible = true;
            await Task.Delay((int)seconds);
            pnlNotification.Visible = false;
        }
    }
}
