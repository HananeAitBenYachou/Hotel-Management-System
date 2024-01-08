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

namespace HotelManagementSystem.Users
{
    public partial class frmShowUserInfo : Form
    {
        private int _UserID;

        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            if(!clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show($"No User with ID = {_UserID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlUserCard1.LoadUserData(_UserID);
        }


    }
}
