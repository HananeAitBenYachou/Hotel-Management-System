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

namespace HotelManagementSystem.Guests
{
    public partial class frmShowGuestCompanions : Form
    {
        private int _BookingID = -1;
        public frmShowGuestCompanions(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }

        private void frmShowGuestCompanions_Load(object sender, EventArgs e)
        {
            clsBooking Booking = clsBooking.Find(_BookingID);

            if (Booking == null)
            {
                MessageBox.Show($"No Booking with ID = {_BookingID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlBookingInfo1.LoadBookingDataByBookingID(_BookingID);
            dgvGuestCompanionsList.DataSource = clsGuest.GetAllGuestCompanions(Booking.GuestID, Booking.BookingID);
            ctrlPersonCard1.LoadPersonData(Booking.GuestInfo.PersonID);

        }

        private void dgvGuestCompanionsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvGuestCompanionsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
