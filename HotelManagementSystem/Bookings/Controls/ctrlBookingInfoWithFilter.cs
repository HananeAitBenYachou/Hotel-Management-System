using Hotel_BusinessLayer;
using HotelManagementSystem.Bookings.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Orders
{
    public partial class ctrlBookingInfoWithFilter : UserControl
    {
        public event EventHandler<int> OnBookingSelected;

        protected virtual void BookingSelected(int BookingID)
        {
            OnBookingSelected?.Invoke(this, BookingID);
        }

        public bool FilterEnabled
        {
            set
            {
                gbFilter.Enabled = value;
            }

            get
            {
                return gbFilter.Enabled;
            }
        }

        public int BookingID
        {
            get
            {
                return ctrlBookingInfo1.BookingID;
            }
        }

        public clsBooking Booking
        {
            get
            {
                return ctrlBookingInfo1.Booking;
            }
        }

        public ctrlBookingInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadBookingInfo(int BookingID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = BookingID.ToString();
            _FindBooking();
        }

        private void ctrlBookingInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.ResetText();
            FilterFocus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.Select();
        }

        private void _FindBooking()
        {
            switch (cbFilterBy.Text)
            {
                case "Booking ID":
                    ctrlBookingInfo1.LoadBookingDataByBookingID(int.Parse(txtFilterValue.Text.Trim()));
                    break;

                case "Reservation ID":
                    ctrlBookingInfo1.LoadBookingDataByReservationID(int.Parse(txtFilterValue.Text.Trim()));
                    break;
            }

            if (OnBookingSelected != null && FilterEnabled)
            {
                BookingSelected(BookingID);
            }
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindBooking();
        }

    }
}
