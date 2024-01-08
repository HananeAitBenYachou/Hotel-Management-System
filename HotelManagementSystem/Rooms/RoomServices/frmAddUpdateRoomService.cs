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

namespace HotelManagementSystem.Rooms.RoomServices
{
    public partial class frmAddUpdateRoomService : Form
    {
        private enum enMode { AddNew = 1 , Update = 2};

        private enMode _Mode;

        private int _RoomServiceID = -1;

        private clsRoomService _RoomService;

        public frmAddUpdateRoomService(int RoomServiceID)
        {
            InitializeComponent();
            _RoomServiceID = RoomServiceID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateRoomService()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _LoadRoomServiceData()
        {
            _RoomService = clsRoomService.Find(_RoomServiceID);

            if (_RoomService == null)
            {
                MessageBox.Show($"No RoomService with ID = {_RoomServiceID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblRoomServiceID.Text = _RoomService.RoomServiceID.ToString();
            txtTitle.Text = _RoomService.RoomServiceTitle;
            txtDescription.Text = _RoomService.RoomServiceDescription;
            txtFees.Text = _RoomService.RoomServiceFees.ToString();
                   
        }

        private void _ResetDefaultValues()
        {
            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New RoomService";
                _RoomService = new clsRoomService();
            }

            else
            {
                lblTitle.Text = "Update RoomService";
            }

            this.Text = lblTitle.Text;
            lblRoomServiceID.Text = "[????]";
            txtTitle.ResetText();
            txtDescription.ResetText();
            txtFees.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _RoomService.RoomServiceTitle = txtTitle.Text.Trim();
            _RoomService.RoomServiceDescription = txtDescription.Text.Trim();
            _RoomService.RoomServiceFees =  Convert.ToSingle(txtFees.Text);

            if (_RoomService.Save())
            {
                MessageBox.Show("RoomService Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;

                lblRoomServiceID.Text = _RoomService.RoomServiceID.ToString();

                lblTitle.Text = "Update RoomService";
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

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "This field is required ! cannot be left blank");
                return;
            }

            else if (_RoomService.RoomServiceTitle != txtTitle.Text && clsRoomService.IsRoomServiceExist(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "This Room Service already exists !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required ! cannot be left blank");
                return;
            }

            else if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This field is required ! cannot be left blank");
                return;
            }

            else
            {
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void frmUpdateRoomService_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if(_Mode == enMode.Update)
                _LoadRoomServiceData();

        }

    }
}
