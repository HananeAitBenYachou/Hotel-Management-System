using Hotel_BusinessLayer;
using HotelManagementSystem.People;
using HotelManagementSystem.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Reservations.Controls
{
    public partial class ctrlReservationInfo : UserControl
    {
        private int _ReservationID = -1;

        private clsReservation _Reservation;

        public int ReservationID
        {
            get
            {
                return _ReservationID;
            }
        }

        public ctrlReservationInfo()
        {
            InitializeComponent();
        }

        public void ResetReservationInfo()
        {
            lblReservationID.Text = "[????]";
            lblRoomType.Text = "[????]";
            lblRoomNumber.Text = "[????]";
            lblReservationDate.Text = "[????]";
            lblReservedByPerson.Text = "[????]";
            lblNumberOfPeople.Text = "[????]";
            lblReservationStatus.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            lblCreatedDate.Text = "[????]";
        }

        public void LoadReservationData(int ReservationID)
        {
            _Reservation = clsReservation.Find(ReservationID);

            if (_Reservation == null)
            {
                MessageBox.Show($"No Reservation with ID = {ReservationID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetReservationInfo();
                return;
            }

            _ReservationID = _Reservation.ReservationID;

            lblReservationID.Text = _Reservation.ReservationID.ToString();
            lblRoomType.Text = _Reservation.RoomInfo.RoomTypeInfo.RoomTypeTitle;
            lblRoomNumber.Text = _Reservation.RoomInfo.RoomNumber;
            lblReservationDate.Text = _Reservation.ReservationDate.ToShortDateString();
            lblReservedByPerson.Text = _Reservation.ReservationPersonInfo.FullName;
            lblNumberOfPeople.Text = (_Reservation.NumberOfPeople == 1) ? "1 Person" : $"{_Reservation.NumberOfPeople} People"; 
            lblReservationStatus.Text = _Reservation.StatusText;
            lblCreatedByUser.Text = _Reservation.CreatedByUserInfo.UserName;
            lblCreatedDate.Text = _Reservation.CreatedDate.ToShortDateString();

            llbShowPersonInfo.Enabled = true;
            llbShowRoomInfo.Enabled = true;
        }

        private void llbShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowPersonInfo(_Reservation.ReservationPersonID);
            frm.ShowDialog();
        }

        private void llbShowRoomInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowRoomInfo(_Reservation.RoomID);
            frm.ShowDialog();
        }
    
    }
}
