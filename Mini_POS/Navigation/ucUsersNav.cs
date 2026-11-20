using Bll;
using Bll.Utilities;
using DTO;
using Mini_POS.Users;
using Mini_POS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_POS.Navigation
{
    public partial class ucUsersNav : UserControl
    {
        private List<User_DTO> _users = new List<User_DTO>();
        public ucUsersNav()
        {
            InitializeComponent();
        }

        private async void _LoadDataToTable()
        {
            _users = await clsUser.GetAllUsersAsync();
            dgvUsers.DataSource = _users;
        }

        private async void ucUsersNav_Load(object sender, EventArgs e)
        {

            _LoadDataToTable();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.OnUserAddedOrUpdated += Frm_OnUserAddedOrUpdated;
            frm.ShowDialog();
        }

        private void Frm_OnUserAddedOrUpdated()
        {
            _LoadDataToTable();
        }

        private int _GetSelectedUserID()
        {
            return (int)dgvUsers.SelectedRows[0].Cells[0].Value;
        }

        private bool _GetIsActiveUser()
        {
            return (bool)dgvUsers.SelectedRows[0].Cells["IsActive"].Value;
        }

        private void editUSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(_GetSelectedUserID());
            frm.OnUserAddedOrUpdated += Frm_OnUserAddedOrUpdated;
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword frm = new frmUpdatePassword(_GetSelectedUserID());
            frm.ShowDialog();
        }

        private async void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if logged in account
            if (_GetSelectedUserID() == clsGlobal.CurrentUser.UserID)
            {
                PUtilities.ShowNot(
                    "Action Denied",
                    "You cannot deactivate your own currently logged-in account.",
                    3.5f,
                    red: true
                );
                return;
            }

            bool result = (_GetIsActiveUser()) ?
                await clsUser.DeactivateUserAsync(_GetSelectedUserID()) :
                await clsUser.ActivateUserAsync(_GetSelectedUserID());
            string message = (_GetIsActiveUser()) ? "Deactivate" : "Activate";
            if (result)
            {

                PUtilities.ShowNot(
                    "Successfully",
                    $"User {message}ed Successfully.",
                    3f
                   );
                _LoadDataToTable();
            }
            else
            {
                PUtilities.ShowNot(
                    "Faild",
                    $"Faild to {message}.",
                    3f,
                    true
                   );
            }
        }

        private void cmsProducts_Opened(object sender, EventArgs e)
        {
            activateToolStripMenuItem.Text = (_GetIsActiveUser()) ? "Deactivate" : "Activate";
        }
    }
}
