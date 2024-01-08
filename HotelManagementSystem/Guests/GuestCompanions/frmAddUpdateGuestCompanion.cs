using Hotel_BusinessLayer;
using HotelManagementSystem.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Guests.GuestCompanions
{
    public partial class frmAddUpdateGuestCompanion : Form
    {
        private enum enMode { AddNew = 1 , Update = 2}

        private enMode _Mode;

        private clsGuestCompanion _GuestCompanion;

        private clsBooking _Booking;

        private int _GuestCompanionID = 1;

        private int _BookingID = 1;

        private int _PersonID = -1;
        public frmAddUpdateGuestCompanion(int BookingID)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _BookingID = BookingID;
        }

        public frmAddUpdateGuestCompanion(int BookingID, int GuestCompanionID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GuestCompanionID = GuestCompanionID;
            _BookingID = BookingID;
        }

        private void _ResertDefaultValues()
        {
            ctrlBookingInfo1.ResetBookingInfo();
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            ctrlPersonCardWithFilter2.FilterEnabled = true;
            lblGuestCompanionID.Text = "[????]"; 

            if (_Mode == enMode.AddNew)
            {
                _GuestCompanion = new clsGuestCompanion();
                lblTitle.Text = "Add New GuestCompanion";
                ctrlPersonCardWithFilter2.FilterFocus();
            }

            else
                lblTitle.Text = "Update GuestCompanion";
        }

        private void _LoadGuestCompanionData()
        {
            _GuestCompanion = clsGuestCompanion.Find(_GuestCompanionID);
            lblGuestCompanionID.Text = _GuestCompanion.GuestCompanionID.ToString();
        }

        private void _LoadBookingData()
        {
            _Booking = clsBooking.Find(_BookingID);

            if (_Booking == null)
            {
                MessageBox.Show($"No Booking with ID = {_BookingID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            else if (_Booking.Status == clsBooking.enStatus.Completed)
            {
                MessageBox.Show($"This booking is already completed. Adding guest companions is not allowed!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            else if (_Booking.ReservationInfo.NumberOfPeople == 1)
            {
                MessageBox.Show($"This booking was made for a single guest only ! Adding companions is not allowed.", "Not Allowed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            else if (_Booking.ReservationInfo.IsAllGuestCompanionsAdded())
            {
                MessageBox.Show($"You have already reached the maximum number of companions allowed for this booking! You cannot add more companions.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlBookingInfo1.LoadBookingDataByBookingID(_BookingID);
        }

        private void _LoadGuestData()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Booking.GuestInfo.PersonID);
        }

        private void _SaveGuestCompanionData()
        {
            if(_PersonID == -1)
            {
                MessageBox.Show("Please select a person !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonCardWithFilter2.FilterFocus();
                return;
            }

            _GuestCompanion.PersonID = _PersonID;
            _GuestCompanion.BookingID = _BookingID;
            _GuestCompanion.GuestID = _Booking.GuestID;
            _GuestCompanion.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _GuestCompanion.CreatedDate = DateTime.Now;


            if (_GuestCompanion.Save())
            {
                MessageBox.Show("Guest Companion Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;

                lblTitle.Text = "Update GuestCompanion";
                lblGuestCompanionID.Text = _GuestCompanion.GuestCompanionID.ToString();
            }

            else
            {
                MessageBox.Show("Error: Data is not saved successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveGuestCompanionData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateGuestCompanion_Load(object sender, EventArgs e)
        {
            _ResertDefaultValues();

            _LoadBookingData();
            _LoadGuestData();

            if (_Mode == enMode.Update)
                _LoadGuestCompanionData();
        }

        private void ctrlPersonCardWithFilter2_OnPersonSelected(object sender, int PersonID)
        {
            if (PersonID != -1)
                _PersonID = PersonID;

            if (clsGuestCompanion.IsGuestCompanionExist(_BookingID, PersonID))
            {
                MessageBox.Show("This person is already linked with other guest companions ! Please choose another one.", "Not Valid!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonCardWithFilter2.FilterFocus();
                return;
            }

            else if (_Booking.GuestInfo.PersonID == PersonID)
            {
                MessageBox.Show("This person is already linked with the main guest ! Please choose another one.", "Not Valid!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonCardWithFilter2.FilterFocus();
                return;
            }

        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

    }

}
