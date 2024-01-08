using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsGuestOrder
    {
        public enum enOrderTypes { RoomService = 1 , Dining = 2}
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int GuestOrderID { get; private set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CreatedByUserID { get; set; }
        public int BookingID { get; set; }
        public enOrderTypes OrderType { get; set; }
        public string OrderTypeText => OrderType.ToString();
        
        public float Fees
        {
            get
            {
                return clsGuestOrderData.GetOrderPaidFees(this.GuestOrderID);
            }
        }
        public int? RoomServiceID { get; set; }  
        public clsUser CreatedByUser { get;}
        public clsBooking BookingInfo { get; }

        public clsGuestOrder()
        {
            _Mode = enMode.AddNew;
            GuestOrderID = -1;
            RoomID = -1;
            BookingID = -1;
            GuestID = -1;
            OrderDate = DateTime.Now;
            CreatedByUserID = -1;
            RoomServiceID = null;
            OrderType = enOrderTypes.RoomService;
        }
        private clsGuestOrder(int GuestOrderID, int GuestID, int RoomID, DateTime OrderDate, int CreatedByUserID, 
            int BookingID, enOrderTypes OrderType , int? RoomServiceID)
        {
            _Mode = enMode.Update;
            this.GuestOrderID = GuestOrderID;
            this.GuestID = GuestID;
            this.RoomID = RoomID;
            this.OrderDate = OrderDate;
            this.CreatedByUserID = CreatedByUserID;
            this.BookingID = BookingID;
            this.OrderType = OrderType;
            this.RoomServiceID = RoomServiceID;
            BookingInfo = clsBooking.Find(BookingID);
            CreatedByUser = clsUser.Find(CreatedByUserID);
        }

        public static clsGuestOrder Find(int GuestOrderID)
        {
            int GuestID = -1;
            int RoomID = -1;
            DateTime OrderDate = DateTime.Now;
            float Fees = -1;
            int CreatedByUserID = -1;
            int BookingID = -1;
            byte OrderType = 0;
            int? RoomServiceID = null; 

            bool IsFound = clsGuestOrderData.GetGuestOrderInfoByID(GuestOrderID, ref GuestID, ref RoomID, ref OrderDate, ref CreatedByUserID, ref BookingID, ref OrderType, ref RoomServiceID);

            if (IsFound)
                return new clsGuestOrder(GuestOrderID, GuestID, RoomID, OrderDate, CreatedByUserID, BookingID, (enOrderTypes)OrderType, RoomServiceID);
            else
                return null;
        }

        public static bool IsGuestOrderExist(int GuestOrderID)
        {
            return clsGuestOrderData.IsGuestOrderExist(GuestOrderID);
        }

        private bool _AddNewGuestOrder()
        {
            GuestOrderID = clsGuestOrderData.AddNewGuestOrder(GuestID, RoomID, OrderDate, CreatedByUserID, BookingID, (byte)OrderType, RoomServiceID);
            return GuestOrderID != -1;
        }

        private bool _UpdateGuestOrder()
        {
            return clsGuestOrderData.UpdateGuestOrderInfo(GuestOrderID, GuestID, RoomID, OrderDate, CreatedByUserID, BookingID, (byte)OrderType, RoomServiceID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGuestOrder())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateGuestOrder();

            }
            return false;
        }

        public static bool DeleteGuestOrder(int GuestOrderID)
        {
            return clsGuestOrderData.DeleteGuestOrder(GuestOrderID);
        }

        public static DataTable GetAllGuestOrders()
        {
            return clsGuestOrderData.GetAllGuestOrders();
        }

        public static DataTable GetAllGuestOrders(int GuestID)
        {
            return clsGuestOrderData.GetAllGuestOrders(GuestID);
        }

        public static int GetGuestOrdersCount()
        {
            return clsGuestOrderData.GetGuestOrdersCount();
        }
    }
}
