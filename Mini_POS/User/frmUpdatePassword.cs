using Bll;
using DTO;
using Guna.UI2.WinForms;
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
using static DTO.User_DTO;

namespace Mini_POS.Users
{
    public partial class frmUpdatePassword : Form
    {
        private int _userID = -1;

        public frmUpdatePassword(int userID)
        {
            InitializeComponent();
            this._userID = userID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _ValidInputs()
        {
            // Validate inputs
            if ( string.IsNullOrWhiteSpace(tbPassword.Text.Trim()) ||
                string.IsNullOrWhiteSpace(tbConfirmePassword.Text.Trim()))
            {
                PUtilities.ShowNot(
                    "Validation Error",
                    "Please fill in all required fields.",
                    3.5f,
                    red: true
                );
                return false;
            }

            // Check password confirmation match
            if (tbPassword.Text != tbConfirmePassword.Text )
            {
                PUtilities.ShowNot(
                    "Password Mismatch",
                    "Password and Confirm Password do not match. Please re-enter.",
                    3.5f,
                    red: true
                );
                return false;
            }
            return true;
        }
        
        private async void btnAddSave_Click(object sender, EventArgs e)
        {
            if (!_ValidInputs())
            {
                return;
            }

            bool result = await clsUser.UpdateUserPasswordAsync(_userID,tbCurrentPassword.Text.Trim() ,tbPassword.Text.Trim());

            if (result)
            {
                PUtilities.ShowNot(
                    "Password Updated",
                    "The user password has been updated successfully.",
                    3f
                );
                this.Close();
            }
            else
            {
                PUtilities.ShowNot(
                    "Update Failed",
                    "Unable to update the password. Please try again.",
                    4f,
                    red: true
                );
            }
        }
    }
}