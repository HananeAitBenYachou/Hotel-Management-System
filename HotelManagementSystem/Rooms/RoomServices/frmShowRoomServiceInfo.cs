using Hotel_BusinessLayer;
using HotelManagementSystem.Orders;
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
    public partial class frmShowRoomServiceInfo : Form
    {
        private int _RoomServiceID = -1;

        public frmShowRoomServiceInfo(int RoomServiceID)
        {
            InitializeComponent();
            _RoomServiceID = RoomServiceID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowRoomServiceInfo_Load(object sender, EventArgs e)
        {
            if (!clsRoomService.IsRoomServiceExist(_RoomServiceID))
            {
                MessageBox.Show($"No RoomService with ID = {_RoomServiceID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlRoomServiceInfo1.LoadRoomServiceData(_RoomServiceID);
        }
    }
}
