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

namespace HotelManagementSystem.Payments
{
    public partial class frmShowGuestPaymentHistory : Form
    {
        private int _GuestID;

        public frmShowGuestPaymentHistory(int GuestID)
        {
            InitializeComponent();
            _GuestID = GuestID;
        }

        private void frmShowGuestPaymentsHistory_Load(object sender, EventArgs e)
        {
            clsGuest Guest = clsGuest.Find(_GuestID);

            if (Guest == null)
            {
                MessageBox.Show($"No Guest with ID = {_GuestID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonData(Guest.PersonID);

            dgvPaymentsList.DataSource = clsPayment.GetAllPayments(_GuestID);

        }

        private void dgvPaymentsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPaymentsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
