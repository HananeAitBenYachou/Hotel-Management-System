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

namespace HotelManagementSystem.Rooms.RoomServices
{
    public partial class frmListRoomServices : Form
    {
        private DataView _DataView;
        public frmListRoomServices()
        {
            InitializeComponent();
        }

        private void dgvRoomServicesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRoomServicesList.Columns[0].Width = 200;
            dgvRoomServicesList.Columns[1].Width = 200;
            dgvRoomServicesList.Columns[2].Width = 200;
            dgvRoomServicesList.Columns[3].Width = 650;

        }

        private void _RefreshRoomTypesList()
        {
            _DataView = clsRoomService.GetAllRoomServices().DefaultView;
            dgvRoomServicesList.DataSource = _DataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void frmListRoomServices_Load(object sender, EventArgs e)
        {
            _RefreshRoomTypesList();       
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomServiceID = (int) dgvRoomServicesList.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateRoomService(RoomServiceID);
            frm.Show();
            frmListRoomServices_Load(null, null);
        }

        private void btnAddRoomService_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRoomService();
            frm.Show();
            frmListRoomServices_Load(null, null);
        }

        private void _FilterList()
        {
            //Reset the filter in case the none option is selected or the filter value is empty
            if (cbFilterByOptions.Text == "None" || txtFilterValue.Text.Trim() == "")
            {
                _DataView.RowFilter = null;
                return;
            }

            //In this case we deal with string not integers

            if (cbFilterByOptions.Text == "Room Service Title")
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            else
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text != "Room Service Title")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

            if (cbFilterByOptions.Text == "Fees")
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

                if (e.KeyChar == '.' && txtFilterValue.Text.Contains('.'))
                    e.Handled = true;

            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
            }
        }

    }
}
