using Hotel_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Users
{
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID;

        private clsUser _User;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.ResetText();
            txtNewPassword.ResetText();
            txtConfirmPassword.ResetText();

            ctrlUserCard1.ResetUserData();
        }

        private void _LoadUserData()
        {
            ctrlUserCard1.LoadUserData(_UserID);
        }

        private void _UpdateUserPassword()
        {
            if(_User.UpdatePassword(txtNewPassword.Text))
            {
                MessageBox.Show("User Password changed successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }

            else
            {
                MessageBox.Show("Error: User Password was not changed successfully !", "Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID);

            if(_User == null)
            {
                MessageBox.Show($"No User with ID = {_UserID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                this.Close();
                return;
            }

            _LoadUserData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _UpdateUserPassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This field is required ! cannot be left blank");
                return;
            }

            //Check if the entred password is the actual current password
            else if (clsPasswordUtility.ComputeHash(txtCurrentPassword.Text) != _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The current password you entered is incorrect !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This field is required ! cannot be left blank");
                return;
            }

            //Check if the password length is >= 8
            else if (txtNewPassword.Text.Trim().Length < 8)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "The password is too short ! Enter at least 8 characters.");
                return;
            }

            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required ! cannot be left blank");
                return;
            }

            //Check if the confirmation of the password matches the password
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The passwords do not match !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

    }
}
