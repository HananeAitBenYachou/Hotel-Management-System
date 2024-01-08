using Hotel_BusinessLayer;
using HotelManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Rooms
{
    public partial class frmListRooms : Form
    {
        private DataView _DataView;

        private string []_RoomStatusFilters =  {"All","Available", "Booked", "Under Maintenance" };

        private enum _enComboBoxItemsTypes { enRoomTypes = 0, enRoomStatus };
        private _enComboBoxItemsTypes _ComboBoxItemsTypes;

        public frmListRooms()
        {
            InitializeComponent();
        }

        private void _FillComboBoxWithRoomStatus()
        {
            comboBox.Items.Clear();

            foreach(string status in _RoomStatusFilters)
            {
                comboBox.Items.Add(status);
            }

            _ComboBoxItemsTypes = _enComboBoxItemsTypes.enRoomStatus;
        }

        private void _FillComboBoxWithRoomTypes()
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("All");

            foreach (DataRow row in clsRoomType.GetAllRoomTypes().Rows)
            {
                comboBox.Items.Add(row["Room Type Title"]);
            }

            _ComboBoxItemsTypes = _enComboBoxItemsTypes.enRoomTypes;
        }

        private void _FillComboBoxWithItems(string ColumnName)
        {
            if (ColumnName == "Room Type")
                _FillComboBoxWithRoomTypes();
            else
                _FillComboBoxWithRoomStatus();
        }

        private void _RefreshRoomsList()
        {
            _DataView = clsRoom.GetAllRooms().DefaultView;
            dgvRoomsList.DataSource = _DataView;

            comboBox.Visible = false;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterRoomsList()
        {
            if (txtFilterValue.Text.Trim() == "" || cbFilterByOptions.Text == "None")
            {
                _DataView.RowFilter = "";
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, int.Parse(txtFilterValue.Text.Trim()));

        }

        private void frmListRooms_Load(object sender, EventArgs e)
        {
            _RefreshRoomsList();
        }

        private void dgvRoomsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvRoomsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRoom();
            frm.ShowDialog();
            _RefreshRoomsList();
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterByOptions.Text == "Room Type" || cbFilterByOptions.Text == "Status")
            {
                txtFilterValue.Visible = false;
                _FillComboBoxWithItems(cbFilterByOptions.Text);
                comboBox.Visible = true;
                comboBox.Focus();
                comboBox.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                comboBox.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue_TextChanged(null, EventArgs.Empty);
            }

        }
 
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "All")
            {
                _DataView.RowFilter = null;
                return;
            }

            _DataView.RowFilter = string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, comboBox.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterRoomsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int) dgvRoomsList.CurrentRow.Cells[0].Value;
            Form frm = new frmShowRoomInfo(RoomID);
            frm.ShowDialog();
        }

        private void AddRoomtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRoom();
            frm.ShowDialog();
            frmListRooms_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRoomsList.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdateRoom(RoomID);
            frm.ShowDialog();
            frmListRooms_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRoomsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Room with RoomID = {RoomID} ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if(clsRoom.DeleteRoom(RoomID))
            {
                MessageBox.Show($"Room with RoomID = {RoomID} was deleted successfully !", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListRooms_Load(null, null);
            }

            else
            {
                MessageBox.Show($"Delete operation failed. The selected Room cannot be deleted due to existing data dependencies.!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void putUnderMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRoomsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to put this Room with RoomID = {RoomID} under maintenance ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsRoom room = clsRoom.Find(RoomID); 

            if(room != null)
            {
                if (room.SetUnderMaintenance())
                {
                    MessageBox.Show($"Room with RoomID = {RoomID} was put under maintenance successfully !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListRooms_Load(null, null);
                }

                else
                {
                    MessageBox.Show($"Error : Failed to put the room under maintenance !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRoomsList.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to release this Room with RoomID = {RoomID} from maintenance ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsRoom room = clsRoom.Find(RoomID);

            if (room != null)
            {
                if (room.SetAvailable())
                {
                    MessageBox.Show($"Room with RoomID = {RoomID} was released from maintenance successfully !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListRooms_Load(null, null);
                }

                else
                {
                    MessageBox.Show($"Error : Failed to release the room from maintenance !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsRooms_Opening(object sender, CancelEventArgs e)
        {
            int RoomID = (int)dgvRoomsList.CurrentRow.Cells[0].Value;

            clsRoom room = clsRoom.Find(RoomID);

            bool IsRoomAvailable = room.AvailabilityStatus == clsRoom.enAvailabilityStatus.Available;

            bool IsRoomUnderMaintenance = room.AvailabilityStatus == clsRoom.enAvailabilityStatus.UnderMaintenance; 

            putUnderMaintenanceToolStripMenuItem.Enabled = IsRoomAvailable;

            releaseToolStripMenuItem.Enabled = IsRoomUnderMaintenance;

            editToolStripMenuItem.Enabled = IsRoomAvailable || IsRoomUnderMaintenance;

            deleteToolStripMenuItem.Enabled = IsRoomAvailable || IsRoomUnderMaintenance;
        }

    }
}
