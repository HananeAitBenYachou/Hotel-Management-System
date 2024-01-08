using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsOrderItem
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int OrderItemID { get; private set; }
        public int ItemID { get; set; }
        public int OrderID { get; set; }
        public int BookingID { get; set; }
        public byte Quantity { get; set; }
        public float Price { get; set; }

        public clsOrderItem()
        {
            _Mode = enMode.AddNew;
            OrderItemID = -1;
            ItemID = -1;
            OrderID = -1;
            BookingID = -1;
            Quantity = 0;
            Price = 0;
        }
        private clsOrderItem(int OrderItemID, int ItemID, int OrderID, int BookingID, byte Quantity, float Price)
        {
            _Mode = enMode.Update;
            this.OrderItemID = OrderItemID;
            this.ItemID = ItemID;
            this.OrderID = OrderID;
            this.BookingID = BookingID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public static clsOrderItem Find(int OrderItemID)
        {
            int ItemID = -1;
            int OrderID = -1;
            int BookingID = -1;
            byte Quantity = 0;
            float Price = -1;

            bool IsFound = clsOrderItemData.GetOrderItemInfoByID(OrderItemID, ref ItemID, ref OrderID, ref BookingID, ref Quantity, ref Price);

            if (IsFound)
                return new clsOrderItem(OrderItemID, ItemID, OrderID, BookingID, Quantity, Price);
            else
                return null;
        }

        public static bool IsOrderItemExist(int OrderItemID)
        {
            return clsOrderItemData.IsOrderItemExist(OrderItemID);
        }

        private bool _AddNewOrderItem()
        {
            OrderItemID = clsOrderItemData.AddNewOrderItem(ItemID, OrderID, BookingID, Quantity, Price);
            return OrderItemID != -1;
        }

        private bool _UpdateOrderItem()
        {
            return clsOrderItemData.UpdateOrderItemInfo(OrderItemID, ItemID, OrderID, BookingID, Quantity, Price);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewOrderItem())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateOrderItem();

            }
            return false;
        }

        public static bool DeleteOrderItem(int OrderItemID)
        {
            return clsOrderItemData.DeleteOrderItem(OrderItemID);
        }

        public static DataTable GetAllOrderItems()
        {
            return clsOrderItemData.GetAllOrderItems();
        }

        public static DataTable GetAllOrderItems(int OrderID)
        {
            return clsOrderItemData.GetAllOrderItems(OrderID);
        }

    }
}
