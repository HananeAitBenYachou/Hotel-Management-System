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

namespace HotelManagementSystem.Orders
{
    public partial class frmShowGuestOrdersHistory : Form
    {
        private int _GuestID;

        public frmShowGuestOrdersHistory(int GuestID)
        {
            InitializeComponent();
            _GuestID = GuestID;
        }

        private void frmShowGuestOrdersHistory_Load(object sender, EventArgs e)
        {
            clsGuest Guest = clsGuest.Find(_GuestID);

            if (Guest == null)
            {
                MessageBox.Show($"No Guest with ID = {_GuestID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonData(Guest.PersonID);
            dgvOrdersList.DataSource = clsGuestOrder.GetAllGuestOrders(_GuestID);
        }

        private void dgvOrdersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvOrdersList.Columns)
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
