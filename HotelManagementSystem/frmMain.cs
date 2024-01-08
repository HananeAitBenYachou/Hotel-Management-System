using Guna.UI2.WinForms;
using Hotel_BusinessLayer;
using HotelManagementSystem.Bookings;
using HotelManagementSystem.GlobalClasses;
using HotelManagementSystem.Guests;
using HotelManagementSystem.Login;
using HotelManagementSystem.MenuItems;
using HotelManagementSystem.Orders;
using HotelManagementSystem.Payments;
using HotelManagementSystem.People;
using HotelManagementSystem.Properties;
using HotelManagementSystem.Reservations;
using HotelManagementSystem.Rooms;
using HotelManagementSystem.Rooms.RoomServices;
using HotelManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        public frmMain(frmLogin LoginForm)
        {
            InitializeComponent();
            _frmLogin = LoginForm;
        }

        private void _FillFormInPanelContainer(Form frm)
        {
            frm.BackColor = panelContainer.FillColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
     
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(frm);

            frm.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmDashboard());

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListReservations());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListBookings());

        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListRooms());
        }

        private void btnRoomTypes_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListRoomTypes());
        }

        private void btnRoomServices_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListRoomServices());
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListGuests());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListUsers());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmListPayments());
        }

        private void btnDiningMenu_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new MenuItems.frmListMenuItems());

        }

        private void btnGuestOrders_Click(object sender, EventArgs e)
        {
           _FillFormInPanelContainer(new frmListGuestOrders());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }
    }
}
