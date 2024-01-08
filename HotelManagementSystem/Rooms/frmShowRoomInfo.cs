using Hotel_BusinessLayer;
using HotelManagementSystem.Users.Controls;
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
    public partial class frmShowRoomInfo : Form
    {
        private int _RoomID = -1;

        private string _RoomNumber = "";

        public frmShowRoomInfo(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;
            this.Load += frmShowRoomInfo_LoadByRoomID;
        }

        public frmShowRoomInfo(string RoomNumber)
        {
            InitializeComponent();
            _RoomNumber = RoomNumber;
            this.Load += frmShowRoomInfo_LoadByRoomNumber;
        }

        private void _LoadRoomData(int RoomID)
        {
            if (!clsRoom.IsRoomExist(RoomID))
            {
                MessageBox.Show($"No Room with ID = {RoomID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlRoomInfo1.LoadRoomData(RoomID);
        }

        private void _LoadRoomData(string RoomNumber)
        {
            if (!clsRoom.IsRoomExist(RoomNumber))
            {
                MessageBox.Show($"No Room with Number = {RoomNumber} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlRoomInfo1.LoadRoomData(RoomNumber);
        }

        private void frmShowRoomInfo_LoadByRoomID(object sender, EventArgs e)
        {
            _LoadRoomData(_RoomID);
            this.Load -= frmShowRoomInfo_LoadByRoomID;
        }

        private void frmShowRoomInfo_LoadByRoomNumber(object sender, EventArgs e)
        {
            _LoadRoomData(_RoomNumber);
            this.Load -= frmShowRoomInfo_LoadByRoomNumber;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
