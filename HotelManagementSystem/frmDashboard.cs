using Hotel_BusinessLayer;
using HotelManagementSystem.GlobalClasses;
using HotelManagementSystem.Reservations;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void _LoadDashboardData()
        {
            label.Text = $"Hi {clsGlobal.CurrentUser.UserName} !";
            lblUserFullName.Text = clsGlobal.CurrentUser.PersonInfo.FullName;
            lblUserEmail.Text = clsGlobal.CurrentUser.PersonInfo.Email;


            lblRoomsCount.Text = clsRoom.GetRoomsCount().ToString();
            lblReservationsCount.Text = clsReservation.GetReservationsCount().ToString();
            lblBookingsCount.Text = clsBooking.GetBookingsCount().ToString();
            lblPaymentsCount.Text = clsPayment.GetPaymentsCount().ToString();
            lblGuestsCount.Text = (clsGuest.GetGuestsCount() + clsGuestCompanion.GetGuestCompanionsCount()).ToString();
            lblUsersCount.Text = clsUser.GetUsersCount().ToString();

        }

        private void _LoadChartData()
        {
            Series serie = chart1.Series["RoomsStatus"];

            serie.Points[0].SetValueY(clsRoom.GetRoomsCountPerStatus(clsRoom.enAvailabilityStatus.Booked));
            serie.Points[1].SetValueY(clsRoom.GetRoomsCountPerStatus(clsRoom.enAvailabilityStatus.Available));
            serie.Points[2].SetValueY(clsRoom.GetRoomsCountPerStatus(clsRoom.enAvailabilityStatus.UnderMaintenance));

            serie.Points[0].Color = ColorTranslator.FromHtml("#b676b1");
            serie.Points[1].Color = ColorTranslator.FromHtml("#fecf6a");
            serie.Points[2].Color = ColorTranslator.FromHtml("#df1c44");


        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {         
            _LoadDashboardData();

            _LoadChartData();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateReservation();
            frm.ShowDialog();
        }

        private void viewProfileDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangeUserPassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
    
    }
}
