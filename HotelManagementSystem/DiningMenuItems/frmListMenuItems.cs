using Hotel_BusinessLayer;
using HotelManagementSystem.DiningMenuItems;
using HotelManagementSystem.Guests.GuestCompanions;
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

namespace HotelManagementSystem.MenuItems
{
    public partial class frmListMenuItems : Form
    {

        private DataView _DataView;

        public frmListMenuItems()
        {
            InitializeComponent();
        }

        private void _RefreshMenuItems()
        {
            int ItemID;

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRowView row in _DataView)
            {
                ctrlMenuItemInfo menuItemInfo = new ctrlMenuItemInfo();

                ItemID = (int)row["Item ID"];

                menuItemInfo.LoadMenuItemData(ItemID);

                flowLayoutPanel1.Controls.Add(menuItemInfo);
            }

        }

        private void _RefreshMenuItemsList()
        {
            _DataView = clsMenuItem.GetAllMenuItems().DefaultView;
            dgvMenuItemsList.DataSource = _DataView;
          
            cbItemType.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
            cbDisplayOption.SelectedIndex = 0;

           _RefreshMenuItems();

        }

        private void _FilterMenuItemsList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                _RefreshMenuItems();
                return;
            }

            if (cbFilterByOptions.Text == "Item ID")
                _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));
            else
                _DataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());

            _RefreshMenuItems();
        }

        private void frmListMenuItems_Load(object sender, EventArgs e)
        {
            _RefreshMenuItemsList();
        }

        private void dgvMenuItemsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMenuItemsList.Columns)
            {
                column.Width = 180;
            }

            dgvMenuItemsList.Columns[dgvMenuItemsList.ColumnCount - 1].Width = 600;
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Item Type")
            {
                txtFilterValue.Visible = false;
                cbItemType.Visible = true;
                cbItemType.Focus();
                cbItemType.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                cbItemType.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItemType.Text == "All")
            {
                _DataView.RowFilter = null;
                _RefreshMenuItems();
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbItemType.Text);
            _RefreshMenuItems();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterMenuItemsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Item ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cbDisplayOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDisplayOption.Text == "List")
            {
                dgvMenuItemsList.Visible = true;
                flowLayoutPanel1.Visible = false;
            }

            else
            {
                dgvMenuItemsList.Visible = false;
                flowLayoutPanel1.Visible = true;
            }

        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateMenuItem();
            frm.Show();
            frmListMenuItems_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemID = (int)dgvMenuItemsList.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateMenuItem(ItemID);
            frm.Show();
            frmListMenuItems_Load(null, null);

        }
    }
}
