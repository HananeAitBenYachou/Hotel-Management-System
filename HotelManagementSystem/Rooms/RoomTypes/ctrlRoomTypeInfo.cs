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

namespace HotelManagementSystem.Rooms.RoomTypes
{
    public partial class ctrlRoomTypeInfo : UserControl
    {
        private int _RoomTypeID = -1;

        private clsRoomType _RoomType;
        public int RoomTypeID
        {
            get
            {
                return _RoomTypeID;
            }
        }

        public ctrlRoomTypeInfo()
        {
            InitializeComponent();
        }

        public void ResetRoomTypeInfo()
        {
            lblRoomTypeID.Text = "[????]";
            lblRoomTypeTitle.Text = "[????]";
            lblRoomTypeCapacity.Text = "[????]";
            lblRoomTypePerNightPrice.Text = "[????]";
            lblRoomCountPerRoomType.Text = "[????]";
            txtDescription.Text = "????";
        }

        public void LoadRoomTypeData(int RoomTypeID)
        {
            _RoomType = clsRoomType.Find(RoomTypeID);

            if(_RoomType == null)
            {
                MessageBox.Show($"No RoomType with ID = {RoomTypeID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetRoomTypeInfo();
                return;
            }

            int TotalRooms = clsRoom.GetRoomsCount();

            _RoomTypeID = _RoomType.RoomTypeID;
            lblRoomTypeID.Text = _RoomType.RoomTypeID.ToString();
            lblRoomTypeTitle.Text = _RoomType.RoomTypeTitle;
            lblRoomTypeCapacity.Text = _RoomType.RoomTypeCapacity.ToString();
            lblRoomTypePerNightPrice.Text = _RoomType.RoomTypePricePerNight.ToString();
            lblRoomCountPerRoomType.Text = _RoomType.GetRoomsCount().ToString() + $"/{TotalRooms}";
            txtDescription.Text = _RoomType.RoomTypeDescription;
        }

        private void ctrlRoomTypeInfo_Load(object sender, EventArgs e)
        {
            ResetRoomTypeInfo();
        }

    }
}
