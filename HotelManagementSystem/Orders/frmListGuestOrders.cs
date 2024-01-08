using Hotel_BusinessLayer;
using HotelManagementSystem.Reservations;
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
    public partial class frmListGuestOrders : Form
    {
        private DataView _DataView;

        public frmListGuestOrders()
        {
            InitializeComponent();
        }

        private void _RefreshGuestOrdersList()
        {
            _DataView = clsGuestOrder.GetAllGuestOrders().DefaultView;
            dgvGuestOrdersList.DataSource = _DataView;

            cbStatus.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterGuestOrdersList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            if (cbFilterByOptions.Text == "Booking ID" || cbFilterByOptions.Text == "Order ID")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListGuestOrders_Load(object sender, EventArgs e)
        {
            _RefreshGuestOrdersList();
        }

        private void dgvGuestOrdersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvGuestOrdersList.Columns)
            {
                column.Width = 200;
            }
        }

        private void btnAddGuestOrder_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddGuestOrder();
            frm.ShowDialog();
            _RefreshGuestOrdersList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Order Type")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
                cbStatus.Focus();
                cbStatus.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                cbStatus.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text == "All")
            {
                _DataView.RowFilter = null;
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbStatus.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterGuestOrdersList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Booking ID" || cbFilterByOptions.Text == "Order ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = (int)dgvGuestOrdersList.CurrentRow.Cells[0].Value;

            Form frm = new frmShowOrderInfo(OrderID);
            frm.ShowDialog();
            frmListGuestOrders_Load(null, null);
        }

    }
}
