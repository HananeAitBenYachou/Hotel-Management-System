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
    public partial class ctrlRoomServiceInfo : UserControl
    {
        private int _RoomServiceID = -1;

        private clsRoomService _RoomService;
        public int RoomServiceID
        {
            get
            {
                return _RoomServiceID;
            }
        }

        public ctrlRoomServiceInfo()
        {
            InitializeComponent();
        }

        public void ResetRoomServiceInfo()
        {
            lblRoomServiceID.Text = "[????]";
            lblTitle.Text = "[????]";
            lblFees.Text = "[????]";
            txtDescription.Text = "????";
        }

        public void LoadRoomServiceData(int RoomServiceID)
        {
            _RoomService = clsRoomService.Find(RoomServiceID);

            if (_RoomService == null)
            {
                MessageBox.Show($"No RoomService with ID = {RoomServiceID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetRoomServiceInfo();
                return;
            }

            _RoomServiceID = _RoomService.RoomServiceID;

            lblRoomServiceID.Text = _RoomService.RoomServiceID.ToString();
            lblTitle.Text = _RoomService.RoomServiceTitle;
            lblFees.Text = _RoomService.RoomServiceFees.ToString();
            txtDescription.Text = _RoomService.RoomServiceDescription;
        }

        private void ctrlRoomServiceInfo_Load(object sender, EventArgs e)
        {
            ResetRoomServiceInfo();
        }

    }
}
