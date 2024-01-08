using Hotel_BusinessLayer;
using HotelManagementSystem.Reservations.Controls;
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
    public partial class frmShowBookingInfo : Form
    {
        private int _BookingID = -1;

        public frmShowBookingInfo(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookingInfo_Load(object sender, EventArgs e)
        {
            if (!clsBooking.IsBookingExist(_BookingID))
            {
                MessageBox.Show($"No Booking with ID = {_BookingID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlBookingInfo1.LoadBookingDataByBookingID(_BookingID);
        }

    }
}
