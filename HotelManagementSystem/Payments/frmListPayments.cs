using Hotel_BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Payments
{
    public partial class frmListPayments : Form
    {
        private DataView _DataView;

        public frmListPayments()
        {
            InitializeComponent();
        }

        private void _RefreshPaymentsList()
        {
            _DataView = clsPayment.GetAllPayments().DefaultView;
            dgvPaymentsList.DataSource = _DataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterPaymentsList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            if (cbFilterByOptions.Text == "Payment ID" || cbFilterByOptions.Text == "Booking ID")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {
            _RefreshPaymentsList();
        }

        private void dgvPaymentsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPaymentsList.Columns)
            {
                column.Width = 300;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
            txtFilterValue_TextChanged(null, EventArgs.Empty);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterPaymentsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Payment ID" || cbFilterByOptions.Text == "Booking ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = (int)dgvPaymentsList.CurrentRow.Cells[0].Value;

            frmPaymentInvoice frmInvoice = new frmPaymentInvoice(PaymentID);

            frmInvoice.ShowDialog();
        }
   
    
    }
}
