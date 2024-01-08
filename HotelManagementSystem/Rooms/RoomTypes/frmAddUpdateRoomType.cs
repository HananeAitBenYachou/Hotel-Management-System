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

namespace HotelManagementSystem.Rooms.RoomTypes
{
    public partial class frmAddUpdateRoomType : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode;

        private int _RoomTypeID = -1;

        private clsRoomType _RoomType;

        public frmAddUpdateRoomType(int RoomTypeID)
        {
            InitializeComponent();
            _RoomTypeID = RoomTypeID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateRoomType()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _LoadRoomTypeData()
        {
            _RoomType = clsRoomType.Find(_RoomTypeID);

            if (_RoomType == null)
            {
                MessageBox.Show($"No RoomType with ID = {_RoomTypeID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblRoomTypeID.Text = _RoomType.RoomTypeID.ToString();
            txtRoomTypeTitle.Text = _RoomType.RoomTypeTitle;
            txtDescription.Text = _RoomType.RoomTypeDescription;
            txtPerNightPrice.Text = _RoomType.RoomTypePricePerNight.ToString();
            nudRoomTypeCapacity.Value = _RoomType.RoomTypeCapacity;

        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New RoomType";
                _RoomType = new clsRoomType();
            }

            else
            {
                lblTitle.Text = "Update RoomType";
            }

            this.Text = lblTitle.Text;

            lblRoomTypeID.Text = "[????]";
            txtRoomTypeTitle.ResetText();
            txtDescription.ResetText();
            txtPerNightPrice.ResetText();
            nudRoomTypeCapacity.Value = 1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _RoomType.RoomTypeTitle = txtRoomTypeTitle.Text;
            if(txtDescription.Text != "")
            _RoomType.RoomTypeDescription = txtDescription.Text;
            _RoomType.RoomTypePricePerNight = Convert.ToSingle(txtPerNightPrice.Text);
            _RoomType.RoomTypeCapacity = (byte)nudRoomTypeCapacity.Value;

            if (_RoomType.Save())
            {
                MessageBox.Show("RoomType Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;

                lblRoomTypeID.Text = _RoomType.RoomTypeID.ToString();

                lblTitle.Text = "Update RoomType";
                this.Text = lblTitle.Text;

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

        private void txtRoomTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomTypeTitle, "This field is required ! cannot be left blank");
                return;
            }

            else if (_RoomType.RoomTypeTitle != txtRoomTypeTitle.Text && clsRoomType.IsRoomTypeExist(txtRoomTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomTypeTitle, "This RoomType already exists !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtRoomTypeTitle, null);
            }
        }

        private void txtPerNightPrice_Validating(object sender, CancelEventArgs e)
        {    
            if (!clsValidation.IsNumber(txtPerNightPrice.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPerNightPrice, "Invalid Number !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtPerNightPrice, null);
            }
        }

        private void frmAddUpdateRoomType_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadRoomTypeData();
        }

    }
}
