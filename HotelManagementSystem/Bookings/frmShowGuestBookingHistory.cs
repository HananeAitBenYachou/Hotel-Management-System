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

namespace HotelManagementSystem.Bookings
{
    public partial class frmShowGuestBookingHistory : Form
    {
        private int _GuestID = -1;

        public frmShowGuestBookingHistory(int GuestID)
        {
            InitializeComponent();
            _GuestID = GuestID;
        }

        private void frmShowGuestBookingsHistory_Load(object sender, EventArgs e)
        {
            clsGuest Guest = clsGuest.Find(_GuestID);

            if (Guest == null)
            {
                MessageBox.Show($"No Guest with ID = {_GuestID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonData(Guest.PersonID);
            dgvBookingsList.DataSource = clsBooking.GetAllGuestBookings(_GuestID);
        }

        private void dgvBookingsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBookingsList.Columns)
            {
                column.Width = 150;
            }
        }
    
    }
}
