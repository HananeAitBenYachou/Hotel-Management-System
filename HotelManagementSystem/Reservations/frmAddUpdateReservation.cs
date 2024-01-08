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

namespace HotelManagementSystem.Reservations
{
    public partial class frmAddUpdateReservation : Form
    {
        private enum enMode { AddNew, Update };

        private enMode _Mode;

        private int _PersonID = -1;

        private int _ReservationID = -1;

        private clsReservation _Reservation;

        private int AvailableRoomTypeID = 0;

        public frmAddUpdateReservation(int ReservationID)
        {
            InitializeComponent();
            _ReservationID = ReservationID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateReservation()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _FillRoomTypesInComboBox()
        {
            foreach (DataRow row in clsRoomType.GetAllRoomTypes().Rows)
            {
                cbRoomTypes.Items.Add(row["Room Type Title"]);
            }
        }

        private void _FillAvailableRoomsInComboBox(int RoomTypeID)
        {
            cbAvailableRooms.Items.Clear();

            foreach (DataRow row in clsRoom.GetAvailableRoomsPerRoomType(RoomTypeID).Rows)
            {
                cbAvailableRooms.Items.Add(row["RoomNumber"]);
            }

            if(cbAvailableRooms.Items.Count == 0)
            {
                MessageBox.Show("There is no available rooms for this type , please choose another one",
                    "No Available Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbRoomTypes.SelectedIndex = cbRoomTypes.FindString(clsRoomType.Find(AvailableRoomTypeID).RoomTypeTitle);
            }
        }

        private void _ResetDefaultValues()
        {
            //reset the form and its controls to their default values 

            _FillRoomTypesInComboBox();

            AvailableRoomTypeID = clsReservation.GetAvailableRoomType();

            if (_Mode == enMode.AddNew)
            {
                if(AvailableRoomTypeID == 0)
                {
                    MessageBox.Show($"No Available rooms for the moment , Please check later !", "Not Vacant rooms !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                _Reservation = new clsReservation();
                lblTitle.Text = "Add New Reservation";
                lblReservationStatus.Text = _Reservation.StatusText;
                lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
                ctrlPersonCardWithFilter1.FilterFocus();

                dtpReservedForDate.MinDate = DateTime.Now;
                dtpReservedForDate.MaxDate = DateTime.Now.AddMonths(3);
            }

            else
            {
                lblTitle.Text = "Update Reservation";
            }

            this.Text = lblTitle.Text;

            lblReservationID.Text = "[????]";
            dtpReservedForDate.Value = DateTime.Now;
            cbRoomTypes.SelectedIndex = cbRoomTypes.FindString(clsRoomType.Find(AvailableRoomTypeID).RoomTypeTitle);
            nudNumberOfPeople.Value = 1;

            tpReservationInfo.Enabled = (_Mode == enMode.Update);
            btnSave.Enabled = tpReservationInfo.Enabled;
        }

        private void _LoadReservationData()
        {
            //Load reservation information from the database 
            _Reservation = clsReservation.Find(_ReservationID);

            ctrlPersonCardWithFilter1.FilterEnabled = false;

            //check the if the reservation exists , if not close the form 
            if (_Reservation == null)
            {
                MessageBox.Show($"No Reservation with ID = {_ReservationID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Reservation.ReservationPersonID);

            lblReservationID.Text = _Reservation.ReservationID.ToString();
            lblCreatedByUser.Text = _Reservation.CreatedByUserInfo.UserName;
            dtpReservedForDate.Value = _Reservation.ReservationDate;
            cbRoomTypes.SelectedIndex = cbRoomTypes.FindString(clsRoomType.Find(_Reservation.RoomInfo.RoomTypeID).RoomTypeTitle);
            cbAvailableRooms.SelectedIndex = cbAvailableRooms.FindString(_Reservation.RoomInfo.RoomNumber);
            nudNumberOfPeople.Value = _Reservation.NumberOfPeople;
            lblReservationStatus.Text = _Reservation.StatusText;

        }

        private void frmAddUpdateReservation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadReservationData();
        }

        private void cbRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsRoomType RoomType = clsRoomType.Find(cbRoomTypes.Text);

            nudNumberOfPeople.Maximum = RoomType.RoomTypeCapacity;

            _FillAvailableRoomsInComboBox(RoomType.RoomTypeID);

            cbAvailableRooms.SelectedIndex = 0;
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, int PersonID)
        {
            //check if the person selected exists
            if (PersonID != -1)
                _PersonID = PersonID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check if the controls of this form are all valid 

            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Reservation.ReservationPersonID = ctrlPersonCardWithFilter1.PersonID;
            _Reservation.RoomID = clsRoom.Find(cbAvailableRooms.Text).RoomID;
            _Reservation.ReservationDate = dtpReservedForDate.Value;
            _Reservation.NumberOfPeople = (byte)nudNumberOfPeople.Value;
            _Reservation.Status = clsReservation.enReservationStatus.Pending;
            _Reservation.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Reservation.Save())
            {
                MessageBox.Show("Reservation Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTitle.Text = "Update Reservation";

                lblReservationID.Text = _Reservation.ReservationID.ToString();

                //change the mode to update mode
                _Mode = enMode.Update;
            }

            else
            {
                MessageBox.Show("Error: Data is not saved successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if a person is selected 
            if (_PersonID == -1)
            {
                MessageBox.Show("Please select a person !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
                return;
            }

            //If you reach here then a valid person was selected successfully
            tpReservationInfo.Enabled = true;
            btnSave.Enabled = true;
            tcReservationInfo.SelectedTab = tpReservationInfo;
        }

        private void dtpReservedForDate_Validating(object sender, CancelEventArgs e)
        {
            int RoomID = clsRoom.Find(cbAvailableRooms.Text).RoomID;

            if (clsReservation.IsRoomHasActiveReservationAt(RoomID, dtpReservedForDate.Value))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpReservedForDate, "There is already an active reservation for this room at this date !");
                return;
            }

            else
            {
                errorProvider1.SetError(dtpReservedForDate, null);
            }
        }

       

    }
}
