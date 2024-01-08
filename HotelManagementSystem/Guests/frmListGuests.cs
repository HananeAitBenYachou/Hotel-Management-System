using Hotel_BusinessLayer;
using HotelManagementSystem.Bookings;
using HotelManagementSystem.Orders;
using HotelManagementSystem.Payments;
using HotelManagementSystem.People;
using HotelManagementSystem.Reservations;
using HotelManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Guests
{
    public partial class frmListGuests : Form
    {
        private DataView _DataView;

        public frmListGuests()
        {
            InitializeComponent();
        }

        private void _RefreshGuestsList()
        {
            _DataView = clsGuest.GetAllGuests().DefaultView;
            dgvGuestsList.DataSource = _DataView;

            cbGender.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterGuestsList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            if (cbFilterByOptions.Text == "Guest ID")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListGuests_Load(object sender, EventArgs e)
        {
            _RefreshGuestsList();
        }

        private void dgvGuestsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvGuestsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterByOptions.Text == "Gender")
            {
                txtFilterValue.Visible = false;
                cbGender.Visible = true;
                cbGender.Focus();
                cbGender.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                cbGender.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text == "All")
            {
                _DataView.RowFilter = null;
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbGender.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterGuestsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Guest ID" || cbFilterByOptions.Text == "Phone")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGuestsList.CurrentRow.Cells[1].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGuestsList.CurrentRow.Cells[1].Value;
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            frmListGuests_Load(null, null);

        }

        private void showReservationsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGuestsList.CurrentRow.Cells[1].Value;
            Form frm = new frmShowPersonReservationHistory(PersonID);
            frm.ShowDialog();
        }

        private void showBookingsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvGuestsList.CurrentRow.Cells[0].Value;
            Form frm = new frmShowGuestBookingHistory(GuestID);
            frm.ShowDialog();
        }

        private void showPaymentsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvGuestsList.CurrentRow.Cells[0].Value;
            Form frm = new frmShowGuestPaymentHistory(GuestID);
            frm.ShowDialog();
        }

        private void showOrdersHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvGuestsList.CurrentRow.Cells[0].Value;
            Form frm = new frmShowGuestOrdersHistory(GuestID);
            frm.ShowDialog();
        }
    }
}
