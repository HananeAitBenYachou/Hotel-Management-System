using Hotel_BusinessLayer;
using HotelManagementSystem.Orders;
using HotelManagementSystem.Orders.Controls;
using HotelManagementSystem.Rooms.RoomServices;
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
    public partial class ctrlOrderInfo : UserControl
    {
        private int _GuestOrderID = -1;

        private clsGuestOrder _GuestOrder;
        public int GuestOrderID
        {
            get
            {
                return _GuestOrderID;
            }
        }

        public ctrlOrderInfo()
        {
            InitializeComponent();
        }

        public void _ResetGuestOrderInfo()
        {
            lblOrderID.Text = "[????]";
            lblOrderedBy.Text = "[????]";
            lblBookingID.Text = "[????]";
            lblRoomNumber.Text = "[????]";
            lblOrderType.Text = "[????]";
            lblOrderDate.Text = "[????]";
            lblPaidAmount.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
        }

        public void LoadGuestOrderData(int GuestOrderID)
        {
            _GuestOrder = clsGuestOrder.Find(GuestOrderID);

            if (_GuestOrder == null)
            {
                MessageBox.Show($"No Order with ID = {GuestOrderID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetGuestOrderInfo();
                return;
            }

            lblOrderID.Text = _GuestOrder.GuestOrderID.ToString();
            lblOrderedBy.Text = _GuestOrder.BookingInfo.GuestInfo.PersonInfo.FullName;
            lblBookingID.Text = _GuestOrder.BookingID.ToString();
            lblRoomNumber.Text = _GuestOrder.BookingInfo.ReservationInfo.RoomInfo.RoomNumber;
            lblOrderType.Text = _GuestOrder.OrderTypeText;
            lblOrderDate.Text = _GuestOrder.OrderDate.ToString();
            lblPaidAmount.Text = _GuestOrder.Fees.ToString() + " $";
            lblCreatedByUser.Text = _GuestOrder.CreatedByUser.UserName;

            llbShowOrderItemsInfo.Visible = _GuestOrder.OrderType == clsGuestOrder.enOrderTypes.Dining;
            llbShowRoomServiceInfo.Visible = _GuestOrder.OrderType == clsGuestOrder.enOrderTypes.RoomService;

            llbShowOrderItemsInfo.Enabled = llbShowOrderItemsInfo.Visible;
            llbShowRoomServiceInfo.Enabled = llbShowRoomServiceInfo.Visible;
        }

        private void ctrlOrderInfo_Load(object sender, EventArgs e)
        {
            _ResetGuestOrderInfo();
        }

        private void llbShowOrderItemsInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowOrderItems(_GuestOrder.GuestOrderID);
            frm.ShowDialog();
        }

        private void llbShowRoomServiceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowRoomServiceInfo((int)_GuestOrder.RoomServiceID);
            frm.ShowDialog();
        }
       
    }
}
