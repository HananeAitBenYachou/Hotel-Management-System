using Hotel_BusinessLayer;
using HotelManagementSystem.Bookings;
using HotelManagementSystem.GlobalClasses;
using HotelManagementSystem.Guests.GuestCompanions;
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

namespace HotelManagementSystem.Reservations
{
    public partial class frmListReservations : Form
    {
        private DataView _DataView;

        public frmListReservations()
        {
            InitializeComponent();
        }

        private void _RefreshReservationsList()
        {
            _DataView = clsReservation.GetAllReservations().DefaultView;
            dgvReservationsList.DataSource = _DataView;

            cbStatus.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterReservationsList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            if (cbFilterByOptions.Text == "Reservation ID" || cbFilterByOptions.Text == "Room Number")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {
            _RefreshReservationsList();
        }

        private void dgvReservationsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvReservationsList.Columns)
            {
                column.Width = 210;
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateReservation();
            frm.ShowDialog();
            _RefreshReservationsList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
                cbStatus.Focus();
                cbStatus.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                cbStatus.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {    
            if(cbStatus.Text == "All")
            {
                _DataView.RowFilter = null;
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbStatus.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterReservationsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Reservation ID" || cbFilterByOptions.Text == "Room Number")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cmsReservations_Opening(object sender, CancelEventArgs e)
        {
            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsReservation reservation = clsReservation.Find(ReservationID);

            clsBooking booking = clsBooking.FindByReservationID(ReservationID);

            
            editToolStripMenuItem.Enabled = reservation.IsReservationValid();
            
            deleteToolStripMenuItem.Enabled = reservation.Status == clsReservation.enReservationStatus.Pending;
            
            cancelToolStripMenuItem.Enabled = reservation.Status == clsReservation.enReservationStatus.Pending;
            
            confirmToolStripMenuItem.Enabled = reservation.IsReservationValid() && !reservation.IsBookingConfirmed();
            
            checkInToolStripMenuItem.Enabled = reservation.Status == clsReservation.enReservationStatus.Confirmed && !reservation.IsGuestCheckedIn() && reservation.IsTodayIsReservationDate();

            addGuestCompanionToolStripMenuItem.Enabled = reservation.IsGuestCheckedIn() && !booking.IsGuestCheckedOut()
                && !reservation.IsAllGuestCompanionsAdded();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            Form frm = new frmShowReservationInfo(ReservationID);
            frm.ShowDialog();

            frmListReservations_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateReservation(ReservationID);
            frm.ShowDialog();

            frmListReservations_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsReservation Reservation = clsReservation.Find(ReservationID);

            if (clsReservation.DeleteReservation(ReservationID))
            {
                MessageBox.Show("Reservation deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListReservations_Load(null, null);
            }
            else
            {
                MessageBox.Show("Could not delete this reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to confirm this reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsReservation Reservation = clsReservation.Find(ReservationID);

            if (Reservation != null)
            {
                if (Reservation.Confirm())
                {
                    MessageBox.Show("Reservation confirmed successfully! You can now proceed with the check-in process.", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListReservations_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not confirm this reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsReservation Reservation = clsReservation.Find(ReservationID);

            if (Reservation != null)
            {
                if (Reservation.Cancel())
                {
                    MessageBox.Show("Reservation Cancelled Successfully.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListReservations_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel this reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addGuestCompanionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsBooking Booking = clsBooking.FindByReservationID(ReservationID); 

            if(Booking != null)
            {
                Form frm = new frmAddUpdateGuestCompanion(Booking.BookingID);
                frm.ShowDialog();
            }
        }

        private void checkIntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            clsReservation Reservation = clsReservation.Find(ReservationID);

            if (Reservation != null)
            {
                if (Reservation.CheckIn(clsGlobal.CurrentUser.UserID))
                {
                    MessageBox.Show("Check-in completed successfully", "Check-in Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not confirm this reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
