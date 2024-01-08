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

namespace HotelManagementSystem.Orders.Controls
{
    public partial class frmShowOrderItems : Form
    {
        private int _OrderID;

        public frmShowOrderItems(int OrderID)
        {
            InitializeComponent();
            _OrderID = OrderID;
        }

        private void frmShowOrderItems_Load(object sender, EventArgs e)
        {
            clsOrderItem Order = clsOrderItem.Find(_OrderID);

            if (Order == null)
            {
                MessageBox.Show($"No Order with ID = {_OrderID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dgvOrderItemsList.DataSource = clsOrderItem.GetAllOrderItems(_OrderID);
        }

        private void dgvOrderItemsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvOrderItemsList.Columns)
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
