using Guna.UI2.WinForms;
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
using TheArtOfDevHtmlRenderer.Adapters;

namespace HotelManagementSystem.Rooms
{
    public partial class frmAddUpdateRoom : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private int _RoomID = -1;

        private clsRoom _Room;

        public frmAddUpdateRoom()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateRoom(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;
            _Mode = enMode.Update;
        }

        private void _LoadRoomData()
        {
            // Load the room data from the database
            _Room = clsRoom.Find(_RoomID);

            //Check if the room was found
            if (_Room == null)
            {
                MessageBox.Show($"No Room with ID = {_RoomID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //If no room is found with this roomID , close the form
                this.Close();
                return;
            }

            //fill the controls with the Room data
            lblRoomID.Text = _Room.RoomID.ToString();

            cbRoomTypes.SelectedIndex = cbRoomTypes.FindString(_Room.RoomTypeInfo.RoomTypeTitle);

            txtRoomNumber.Text = _Room.RoomNumber;
            txtRoomSize.Text = _Room.RoomSize.ToString();
            txtNotes.Text = (_Room.AdditionalNotes == "") ? "No Notes" : _Room.AdditionalNotes;

            cbRoomTypes.SelectedIndex = cbRoomTypes.FindString(_Room.RoomTypeInfo.RoomTypeTitle);

            nudFloorNumber.Value = _Room.RoomFloor;

            cbStatus.SelectedIndex = cbStatus.FindString(_Room.AvailabilityStatusText);

            tsIsSmokingAllowed.Checked = _Room.IsSmokingAllowed;

            tsIsPetFriendly.Checked = _Room.IsPetFriendly;

            cbRoomTypes.Enabled = false;

            if (_Room.AvailabilityStatus != clsRoom.enAvailabilityStatus.Booked)
                cbStatus.Items.Remove("Booked");

            else
                cbStatus.Enabled = false;
        }

        private clsRoom.enAvailabilityStatus _GetRoomStatus()
        {
            switch(cbStatus.Text)
            {
                case "Available":
                    return clsRoom.enAvailabilityStatus.Available;

                case "Booked":
                    return clsRoom.enAvailabilityStatus.Booked;

                case "Under-Maintenance":
                    return clsRoom.enAvailabilityStatus.UnderMaintenance;
            }

            return clsRoom.enAvailabilityStatus.Available;
        }

        private void _SaveRoomData()
        {
            _Room.RoomNumber = txtRoomNumber.Text.Trim();
            _Room.RoomFloor = (byte)nudFloorNumber.Value;
            _Room.RoomSize = double.Parse(txtRoomSize.Text.Trim());
            _Room.RoomTypeID = clsRoomType.Find(cbRoomTypes.Text).RoomTypeID;
            _Room.AvailabilityStatus = _GetRoomStatus();
            _Room.IsPetFriendly = tsIsPetFriendly.Checked;
            _Room.IsSmokingAllowed = tsIsSmokingAllowed.Checked;
            _Room.AdditionalNotes = txtNotes.Text.Trim();

            if (_Room.Save())
            {
                MessageBox.Show($"Room Data Saved Successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTitle.Text = "Update Room";

                _RoomID = _Room.RoomID;
                lblRoomID.Text = _RoomID.ToString();

                //change the mode to update mode
                _Mode = enMode.Update;              
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _FillRoomTypesInComboBox()
        {
            foreach (DataRow row in clsRoomType.GetAllRoomTypes().Rows)
            {
                cbRoomTypes.Items.Add(row["Room Type Title"]);
            }
        }

        private void _FillRoomStatusInComboBox()
        {
            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Booked"); 
            cbStatus.Items.Add("Under-Maintenance");
        }

        private void _ResetDefaultValues()
        {
            _FillRoomTypesInComboBox();
            _FillRoomStatusInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Room";
                cbStatus.Items.Remove("Booked");
                _Room = new clsRoom();
            }

            else
            {
                lblTitle.Text = "Update Room";
            }

            //reset the text value to empty for all the textboxes
            this.Text = lblTitle.Text;

            txtRoomNumber.ResetText();
            txtRoomSize.ResetText();
            txtNotes.ResetText();
  
            //set the default roomtype to single
            cbRoomTypes.SelectedIndex = cbRoomTypes.FindString("Single");

            //set the default floor number to 1
            nudFloorNumber.Value = 1;

            //set the default room status to available
            cbStatus.SelectedIndex = cbStatus.FindString("Available");

            //set the default smoking availability to forbidden
            tsIsSmokingAllowed.Checked = false;

            //set the default value of pet friendly to forbidden
            tsIsPetFriendly.Checked = false;
        }

        private void frmAddUpdateRoom_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadRoomData();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveRoomData();
        }

        private void txtRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomNumber, "This field is required ! cannot be left blank");
                return;
            }

            else if (_Room.RoomNumber != txtRoomNumber.Text.Trim() && clsRoom.IsRoomExist(txtRoomNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomNumber, "This number is already taked by another existing room");
                return;
            }

            else
            {
                errorProvider1.SetError(txtRoomNumber, null);
            }
        }

        private void txtRoomSize_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomSize.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomSize, "This field is required ! cannot be left blank");
                return;
            }

            else if (int.Parse(txtRoomSize.Text.Trim()) < 10)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomSize, "Enter a room size greater than or equal to 10.");
                return;
            }

            else
            {
                errorProvider1.SetError(txtRoomSize, null);
            }
        }

    }
}
