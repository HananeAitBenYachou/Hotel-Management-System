using Hotel_BusinessLayer;
using HotelManagementSystem.Rooms.RoomTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmListRoomTypes : Form
    {
        private DataView _DataView; 

        public frmListRoomTypes()
        {
            InitializeComponent();
        }

        private void _RefreshRoomTypesList()
        {
            _DataView = clsRoomType.GetAllRoomTypes().DefaultView;
            dgvRoomTypesList.DataSource = _DataView;

            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterList()
        {
            //Reset the filter in case the none option is selected or the filter value is empty
            if(cbFilterByOptions.Text == "None" || txtFilterValue.Text.Trim() == "" )
            {
                _DataView.RowFilter = null;
                return;
            }

            //In this case we deal with string not integers

            if(cbFilterByOptions.Text == "Room Type Title")
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
            if (cbFilterByOptions.Text != "Room Type Title")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

            if (cbFilterByOptions.Text == "Price Per Night")
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

        private void frmListRoomTypes_Load(object sender, EventArgs e)
        {
            _RefreshRoomTypesList();
        }

        private void dgvRoomTypesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn column in dgvRoomTypesList.Columns)
            {
                column.Width = 350;
            }
        }

        private void frmListRoomTypes_Activated(object sender, EventArgs e)
        {
            txtFilterValue.Focus();
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRoomType();
            frm.ShowDialog();
            frmListRoomTypes_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomTypeID = (int)dgvRoomTypesList.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateRoomType(RoomTypeID);
            frm.ShowDialog();
            frmListRoomTypes_Load(null, null);
        }

    }
}
