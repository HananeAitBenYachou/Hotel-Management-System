using Hotel_BusinessLayer;
using HotelManagementSystem.Reservations.Controls;
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
    public partial class frmShowOrderInfo : Form
    {
        private int _GuestOrderID = -1;

        public frmShowOrderInfo(int GuestOrderID)
        {
            InitializeComponent();
            _GuestOrderID = GuestOrderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowOrderInfo_Load(object sender, EventArgs e)
        {
            if (!clsGuestOrder.IsGuestOrderExist(_GuestOrderID))
            {
                MessageBox.Show($"No Order with ID = {_GuestOrderID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlOrderInfo1.LoadGuestOrderData(_GuestOrderID);
        }
    
    }
}
