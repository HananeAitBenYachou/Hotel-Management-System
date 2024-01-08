using Hotel_DataAccessLayer;
using Hotel_DataAccessLayer.ErrorLogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsBooking
    {
        public enum enStatus { Ongoing = 1 , Completed = 2}
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int BookingID { get; private set; }
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public enStatus Status { get; set; }
        public string StatusText
        {
            get
            {
                return GetBookingStatus();
            }
        }
        
        public int CreatedByUserID { get; set; }

        public clsGuest GuestInfo { get; }
        public clsReservation ReservationInfo { get; }

        public clsUser CreatedByUserInfo { get; }

        public clsBooking()
        {
            _Mode = enMode.AddNew;
            BookingID = -1;
            ReservationID = -1;
            GuestID = -1;
            CheckInDate = DateTime.Now;
            CheckOutDate = null;
            Status = enStatus.Ongoing;
            CreatedByUserID = -1;
        }
        private clsBooking(int BookingID, int ReservationID, int GuestID, DateTime CheckInDate, DateTime? CheckOutDate, enStatus Status, int CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.BookingID = BookingID;
            this.ReservationID = ReservationID;
            this.GuestID = GuestID;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
            this.Status = Status;
            this.CreatedByUserID = CreatedByUserID;

            GuestInfo = clsGuest.Find(GuestID);
            ReservationInfo = clsReservation.Find(ReservationID);
            CreatedByUserInfo = clsUser.Find(CreatedByUserID);
        }

        public static clsBooking Find(int BookingID)
        {
            int ReservationID = -1;
            int GuestID = -1;
            DateTime CheckInDate = DateTime.Now;
            DateTime? CheckOutDate = null;
            byte Status = 1;
            int CreatedByUserID = -1;

            bool IsFound = clsBookingData.GetBookingInfoByID(BookingID, ref ReservationID, ref GuestID, ref CheckInDate, ref CheckOutDate, ref Status, ref CreatedByUserID);

            if (IsFound)
                return new clsBooking(BookingID, ReservationID, GuestID, CheckInDate, CheckOutDate, (enStatus)Status, CreatedByUserID);
            else
                return null;
        }

        public static clsBooking FindByReservationID(int ReservationID)
        {
            int BookingID = -1;
            int GuestID = -1;
            DateTime CheckInDate = DateTime.Now;
            DateTime? CheckOutDate = null;
            byte Status = 1;
            int CreatedByUserID = -1;

            bool IsFound = clsBookingData.GetBookingInfoByReservationID(ReservationID , ref BookingID, ref GuestID, ref CheckInDate, ref CheckOutDate, ref Status, ref CreatedByUserID);

            if (IsFound)
                return new clsBooking(BookingID, ReservationID, GuestID, CheckInDate, CheckOutDate, (enStatus)Status, CreatedByUserID);
            else
                return null;
        }

        public static bool IsBookingExist(int BookingID)
        {
            return clsBookingData.IsBookingExist(BookingID);
        }

        public static bool IsBookingExistByReservationID(int ReservationID)
        {
            return clsBookingData.IsBookingExistByReservationID(ReservationID);
        }

        public static bool IsBookingCompleted(int BookingID)
        {
            return clsBookingData.IsBookingCompleted(BookingID);
        }

        private bool _AddNewBooking()
        {
            BookingID = clsBookingData.AddNewBooking(ReservationID, GuestID, CheckInDate, CheckOutDate, (byte)Status, CreatedByUserID);
            return BookingID != -1;
        }

        private bool _UpdateBooking()
        {
            return clsBookingData.UpdateBookingInfo(BookingID, ReservationID, GuestID, CheckInDate, CheckOutDate, (byte)Status, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBooking())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateBooking();

            }
            return false;
        }

        public static bool DeleteBooking(int BookingID)
        {
            return clsBookingData.DeleteBooking(BookingID);
        }

        public static DataTable GetAllBookings()
        {
            return clsBookingData.GetAllBookings();
        }

        public static DataTable GetAllGuestBookings(int GuestID)
        {
            return clsBookingData.GetAllGuestBookings(GuestID);
        }

        public static string GetBookingStatus(enStatus Status)
        {
            return Status.ToString();
        }

        public string GetBookingStatus()
        {
            return GetBookingStatus(Status);
        }

        public static bool IsAllGuestCompanionsAdded(int ReservationID)
        {
            return clsBookingData.IsAllGuestCompanionsAdded(ReservationID);
        }

        public bool IsGuestCheckedOut()
        {
            return CheckOutDate.HasValue;
        }

        public bool CheckOut(int CreatedByUserID)
        {
            int NumberOfDaysOfStay = 0;

            if (DateTime.Now == CheckInDate)
                NumberOfDaysOfStay = 1;

            else
                NumberOfDaysOfStay = (int)(DateTime.Now - CheckInDate).TotalDays;

            float TotalFees = NumberOfDaysOfStay * ReservationInfo.RoomInfo.RoomTypeInfo.RoomTypePricePerNight;

            clsPayment payment = new clsPayment();

            payment.BookingID = BookingID;
            payment.PaymentDate = DateTime.Now;
            payment.PaidAmount = TotalFees;
            payment.CreatedByUserID = CreatedByUserID;

            if (clsBookingData.CheckOut(BookingID))
            {
                if (payment.Save())
                    return ReservationInfo.RoomInfo.SetAvailable();
            }

            return false;
        }

        public static int GetBookingsCount()
        {
            return clsBookingData.GetBookingsCount();
        }
    }
}
