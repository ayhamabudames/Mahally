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
    public partial class frmAddEditUser : Form
    {
        enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;
        private int _userID = -1;
        private User_DTO _user = null;
        public event Action OnUserAddedOrUpdated;

        private bool _checked = false;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            // Load Roles (Admin = 0, Cashier = 1)
            cbRole.SelectedIndex = 1;

            if (_Mode == enMode.Update)
            {
                _LoadUserDataEditMode();
            }
        }

        private async void _LoadUserDataEditMode()
        {
            tbPassword.Enabled = false;
            tbConfirmePassword.Enabled = false;
            tbUsername.Enabled = false;

            _user = await clsUser.GetUserByIDAsync(_userID);
            if (_user == null)
            {
                //TODO: Message
                return;
            }

            tbFullName.Text = _user.Name;
            tbUsername.Text = _user.Username;
            cbRole.SelectedIndex = _user.Role;

        }

        private bool _ValidInputs()
        {
            // Validate inputs
            if (cbRole.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbFullName.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                (_Mode == enMode.Add && (string.IsNullOrWhiteSpace(tbPassword.Text.Trim()) ||
                string.IsNullOrWhiteSpace(tbConfirmePassword.Text.Trim())))
                )
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
            if (tbPassword.Text != tbConfirmePassword.Text && _Mode == enMode.Add)
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
            byte selectedRole = (byte)(cbRole.SelectedIndex);

            if (_Mode == enMode.Add)
            {
                _user = new User_DTO(
                    tbUsername.Text.Trim(),
                    tbFullName.Text.Trim(),
                    selectedRole
                );
                await _Add();
            }
            else
            {
                _user.Name = tbFullName.Text.Trim();
                _user.Role = (byte)cbRole.SelectedIndex;
                _Update();
            }
        }

        private async Task _Add()
        {

            //if username exists 
            bool usernameExists = await clsUser.IsUserExistByUsername(tbUsername.Text.Trim());
            if (usernameExists)
            {
                PUtilities.ShowNot(
                    "Username Taken",
                    $"The username '{tbUsername.Text.Trim()}' is already in use. Please choose another one.",
                    3.5f,
                    red: true
                );
                return;
            }

            int newUserID = await clsUser.AddNewUser(_user, tbPassword.Text);
            if (newUserID != -1)
            {
                OnUserAddedOrUpdated?.Invoke();
                PUtilities.ShowNot(
                    "User Added",
                    $"The user has been added successfully with ID: {newUserID}.",
                    3f
                );
                this.Close();
            }
            else
            {
                PUtilities.ShowNot(
                    "Add Failed",
                    "Unable to add the user. The username may already exist or input is invalid.",
                    4f,
                    red: true
                );
            }
        }

        private async void _Update()
        {
            // TODO: Implement Update logic later
            bool result = await clsUser.UpdateUserInfoAsync(_userID, tbFullName.Text.Trim(), (byte)cbRole.SelectedIndex);
            if (result)
            {
                OnUserAddedOrUpdated?.Invoke();
                PUtilities.ShowNot(
                    "User Updated",
                    $"The user has been updated successfully with ID: {_userID}.",
                    3f
                );
                this.Close();
            }
            else
            {
                PUtilities.ShowNot(
                    "Update Failed",
                    "Unable to update the user.",
                    4f,
                    red: true
                );
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private async void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (_checked) return;
            _checked = true;

            bool usernameExists = await clsUser.IsUserExistByUsername(tbUsername.Text.Trim());
            if (usernameExists)
            {
                errorProvider1.SetError(tbUsername, "This username is already exists, try diffrent username.");
            }
            else
            {
                errorProvider1.SetError(tbUsername, "");
            }

            await Task.Delay(100);
            _checked = false;
        }
    }
}