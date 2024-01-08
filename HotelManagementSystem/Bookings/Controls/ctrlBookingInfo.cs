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

namespace HotelManagementSystem.Bookings.Controls
{
    public partial class ctrlBookingInfo : UserControl
    {
        private int _BookingID = -1;

        private clsBooking _Booking;

        public int BookingID
        {
            get
            {
                return _BookingID;
            }
        }

        public clsBooking Booking
        {
            get
            {
                return _Booking;
            }
        }

        public ctrlBookingInfo()
        {
            InitializeComponent();
        }

        public void ResetBookingInfo()
        {
            lblBookingID.Text = "[????]";
            lblCheckInDate.Text = "[????]";
            lblCheckOutDate.Text = "[????]";
            lblBookingStatus.Text = "[????]";
            lblCreatedByUser.Text = "[????]";

            ctrlReservationInfo1.ResetReservationInfo();
        }

        private void _LoadBookingData()
        {          
            _BookingID = _Booking.BookingID;

            lblBookingID.Text = _BookingID.ToString();
            lblCheckInDate.Text = _Booking.CheckInDate.ToShortDateString();
            lblCheckOutDate.Text = (_Booking.CheckOutDate?.ToShortDateString()) ?? "[????]";
            lblBookingStatus.Text = _Booking.StatusText;
            lblCreatedByUser.Text = _Booking.CreatedByUserInfo.UserName;

            ctrlReservationInfo1.LoadReservationData(_Booking.ReservationID);
        }

        public void LoadBookingDataByBookingID(int BookingID)
        {
            _Booking = clsBooking.Find(BookingID);

            if(_Booking == null)
            {
                MessageBox.Show($"No Booking with ID = {BookingID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBookingInfo();
                return;
            }

            _LoadBookingData();

        }

        public void LoadBookingDataByReservationID(int ReservationID)
        {
            _Booking = clsBooking.FindByReservationID(ReservationID);

            if (_Booking == null)
            {
                MessageBox.Show($"No Booking with ReservationID = {ReservationID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBookingInfo();
                return;
            }

            _LoadBookingData();

        }

    }
}
