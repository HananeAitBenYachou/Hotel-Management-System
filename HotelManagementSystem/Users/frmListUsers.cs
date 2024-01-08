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
    public partial class frmListUsers : Form
    {
        private DataView _DataView;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            _DataView = clsUser.GetAllUsers().DefaultView;
            dgvUsersList.DataSource = _DataView;

            cbIsActive.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterUsersList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            if (cbFilterByOptions.Text == "Person ID" || cbFilterByOptions.Text == "User ID")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void dgvUsersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvUsersList.Columns)
            {
                column.Width = 250;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cbFilterByOptions.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                cbIsActive.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsActive = false;

            switch (cbIsActive.Text)
            {
                case "All":
                    _DataView.RowFilter = null;
                    return;

                case "Yes":
                    IsActive = true;
                    break;

                case "No":
                    IsActive = false;
                    break;
            }

            _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, IsActive);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterUsersList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Person ID" || cbFilterByOptions.Text == "User ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            Form frm = new frmShowUserInfo(UserID);
        }

        private void AddUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdateUser(UserID);
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this user ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;

            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void changePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            Form frm = new frmChangeUserPassword(UserID);
        }
    
    }
}
