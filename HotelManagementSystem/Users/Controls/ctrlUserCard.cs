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

namespace HotelManagementSystem.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID = -1;

        private clsUser _User;

        public int UserID
        {
            get
            {
                return _UserID;
            }
        }

        public clsUser User
        {
            get
            {
                return _User;
            }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void ResetUserData()
        {
            ctrlPersonCard1.ResetPersonInfo();

            lblUserID.Text = "[????]";
            lblUsername.Text = "[????]";
            lblIsActive.Text = "[????]";
        }

        public void LoadUserData(int UserID)
        {
            _User = clsUser.Find(UserID);

            if(_User == null)
            {
                MessageBox.Show($"No User with ID = {UserID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _UserID = UserID;

            ctrlPersonCard1.LoadPersonData(_User.PersonID);
            lblUserID.Text = _UserID.ToString();
            lblUsername.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

    }
}
