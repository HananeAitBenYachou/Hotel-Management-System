using Hotel_BusinessLayer;
using HotelManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagementSystem.MenuItems
{
    public partial class ctrlMenuItemInfo : UserControl
    {
        private clsMenuItem _Item;

        private int _ItemID = -1;

        public int ItemID
        {
            get
            {
                return _ItemID;
            }
        }

        public clsMenuItem Item
        {
            get
            {
                return _Item;
            }
        }
       
        public ctrlMenuItemInfo()
        {
            InitializeComponent();
        }

        public bool LoadMenuItemData(int ItemID)
        {
            _Item = clsMenuItem.Find(ItemID);

            if (_Item == null)
                return false;
            
            _ItemID = ItemID;
            lblItemName.Text = _Item.ItemName;
            lblPrice.Text = "$ " + _Item.Price.ToString();

            if(_Item.ImagePath != "")
            {
                Image.ImageLocation = _Item.ImagePath;
            }
            else
            {
                Image.Image = Resources.questionMark;
            }

            return true;
        }

    }
}
