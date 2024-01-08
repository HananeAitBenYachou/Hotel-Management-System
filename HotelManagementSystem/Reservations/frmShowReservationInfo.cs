using Hotel_BusinessLayer;
using HotelManagementSystem.Users.Controls;
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
    public partial class frmShowReservationInfo : Form
    {
        private int _ReservationID = -1;
        public frmShowReservationInfo(int ReservationID)
        {
            InitializeComponent();
            _ReservationID = ReservationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowReservationInfo_Load(object sender, EventArgs e)
        {
            if (!clsReservation.IsReservationExist(_ReservationID))
            {
                MessageBox.Show($"No Reservation with ID = {_ReservationID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlReservationInfo1.LoadReservationData(_ReservationID);
        }
    
    }
}
