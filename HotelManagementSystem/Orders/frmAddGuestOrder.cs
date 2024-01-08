using Hotel_BusinessLayer;
using HotelManagementSystem.GlobalClasses;
using HotelManagementSystem.MenuItems;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagementSystem.Orders
{
    public partial class frmAddGuestOrder : Form
    {
        private List<int> selectedMenueItems = new List<int>();

        private int _BookingID = -1;

        private clsRoomService _RoomService;

        private clsGuestOrder _GuestOrder;

        public frmAddGuestOrder()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            rbDining.Checked = true;
            flpSelectedItems.Controls.Clear();

            tpOrderInfo.Enabled = false;
            btnSave.Enabled = false;
        }

        private bool _IsItemSelected(int MenuItemID)
        {
            if (selectedMenueItems.Contains(MenuItemID))
            {
                MessageBox.Show("You have already selected this item !","Item already selected",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }

            selectedMenueItems.Add(MenuItemID);
            return false;
        }

        private void SelectDiningMenuItem(int MenuItemID)
        {
            ctrlMenuItemWithQuantity menuItem = new ctrlMenuItemWithQuantity();

            if (!_IsItemSelected(MenuItemID))
            {
                if (menuItem.LoadMenuItemData(MenuItemID))
                {
                    flpSelectedItems.Controls.Add(menuItem);
                }
            }
        }

        private void frmAddGuestOrder_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void rbDining_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = clsMenuItem.GetAllMenuItems();
            lblListType.Text = "Dining Menu Items";
            btnSelectItem.Visible = true;
            lbl.Visible = true;
            flpSelectedItems.Visible = true;

        }

        private void rbRoomService_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = clsRoomService.GetAllRoomServices();
            lblListType.Text = "Room Services";
            btnSelectItem.Visible = false;
            lbl.Visible = false;
            flpSelectedItems.Visible = false;

        }

        private void dgvList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                column.Width = 200;
            }

        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            int ItemID = (int)dgvList.CurrentRow.Cells[0].Value;

            SelectDiningMenuItem(ItemID);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_BookingID == -1)
            {
                MessageBox.Show("Please select a booking !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlBookingInfoWithFilter1.FilterFocus();
                return;
            }

            else if (clsBooking.IsBookingCompleted(_BookingID))
            {
                MessageBox.Show("The selected booking is already completed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlBookingInfoWithFilter1.FilterFocus();
                return;
            }

            tpOrderInfo.Enabled = true;
            tcOrderInfo.SelectedTab = tpOrderInfo;
            btnSave.Enabled = true;

        }

        private void SaveOrderItems()
        {
            ctrlMenuItemWithQuantity ctrlMenuItem;
            clsOrderItem OrderItem;

            float TotalPaidFees = 0;

            if (selectedMenueItems.Count > 0)
            {
                foreach (Control ctrl in flpSelectedItems.Controls)
                {
                    ctrlMenuItem = (ctrlMenuItemWithQuantity)ctrl;

                    OrderItem = new clsOrderItem();

                    OrderItem.ItemID = ctrlMenuItem.Item.ItemID;
                    OrderItem.OrderID = _GuestOrder.GuestOrderID;
                    OrderItem.BookingID = _BookingID;
                    OrderItem.Quantity = ctrlMenuItem.Quantity;
                    OrderItem.Price = ctrlMenuItem.TotalPrice;

                    if(OrderItem.Save())
                    TotalPaidFees += OrderItem.Price;
                }
            }
        }

        private void SaveOrderPayment()
        {
            clsPayment payment = new clsPayment();

            payment.BookingID = _BookingID;
            payment.PaymentDate = DateTime.Now;
            payment.PaidAmount = _GuestOrder.Fees;
            payment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            payment.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsBooking Booking = clsBooking.Find(_BookingID);

            _GuestOrder = new clsGuestOrder();
            _GuestOrder.BookingID = Booking.BookingID;
            _GuestOrder.GuestID = Booking.GuestID;
            _GuestOrder.RoomID = Booking.ReservationInfo.RoomID;
            _GuestOrder.OrderDate = DateTime.Now;
            _GuestOrder.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _GuestOrder.OrderType = rbRoomService.Checked ? clsGuestOrder.enOrderTypes.RoomService : clsGuestOrder.enOrderTypes.Dining;

            if(_GuestOrder.OrderType == clsGuestOrder.enOrderTypes.RoomService)
            {
                _RoomService = clsRoomService.Find((int) dgvList.CurrentRow.Cells[0].Value);
                _GuestOrder.RoomServiceID = _RoomService.RoomServiceID;
            }

            if (_GuestOrder.Save())
            {
                MessageBox.Show("Order Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_GuestOrder.OrderType == clsGuestOrder.enOrderTypes.Dining)           
                   SaveOrderItems();
                
                SaveOrderPayment();

                ctrlBookingInfoWithFilter1.FilterEnabled = false;
                btnSave.Enabled = false;
                tpOrderInfo.Enabled = false;
            }

            else
            {
                MessageBox.Show("Error: Data is not saved successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ctrlBookingInfoWithFilter1_OnBookingSelected(object sender, int BookingID)
        {
            if (BookingID != -1)
                _BookingID = BookingID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
