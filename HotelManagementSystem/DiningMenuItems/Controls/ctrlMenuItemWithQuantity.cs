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

namespace HotelManagementSystem.MenuItems
{
    public partial class ctrlMenuItemWithQuantity : UserControl
    {
        public int ItemID
        {
            get
            {
                return ctrlMenuItemInfo1.ItemID;
            }
        }

        public clsMenuItem Item
        {
            get
            {
                return ctrlMenuItemInfo1.Item;
            }
        }

        public byte Quantity
        {
            get
            {
                return (byte)nudQuantity.Value;
            }
        }

        public float TotalPrice
        {
            get
            {
                return Convert.ToSingle(ctrlMenuItemInfo1.Item.Price) * Quantity;
            }
        }

        public ctrlMenuItemWithQuantity()
        {
            InitializeComponent();
        }

        public bool LoadMenuItemData(int ItemID)
        {
            return ctrlMenuItemInfo1.LoadMenuItemData(ItemID);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = Parent as FlowLayoutPanel;
            panel?.Controls.Remove(this);
        }

    }
}
