using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsReservation
    {
        public enum enReservationStatus { Pending = 1 , Confirmed = 2 , Cancelled = 3 }
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int ReservationID { get; private set; }
        public int ReservationPersonID { get; set; }
        public int RoomID { get; set; }
        public DateTime ReservationDate { get; set; }
        public byte NumberOfPeople { get; set; }
        public enReservationStatus Status { get; set; }

        public string StatusText
        {
            get
            {
                return Status.ToString();
            }
        }
        public DateTime LastStatusDate { get; private set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; private set; }

        public clsPerson ReservationPersonInfo { get; }
        public clsUser CreatedByUserInfo { get; }
        public clsRoom RoomInfo { get; }

        public clsReservation()
        {
            _Mode = enMode.AddNew;
            ReservationID = -1;
            ReservationPersonID = -1;
            RoomID = -1;
            ReservationDate = DateTime.Now;
            NumberOfPeople = 1;
            Status = enReservationStatus.Pending;
            LastStatusDate = DateTime.Now;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }

        private clsReservation(int ReservationID, int ReservationPersonID, int RoomID, DateTime ReservationDate, byte NumberOfPeople, enReservationStatus Status, 
            DateTime LastStatusDate, int CreatedByUserID, DateTime CreatedDate)
        {
            _Mode = enMode.Update;
            this.ReservationID = ReservationID;
            this.ReservationPersonID = ReservationPersonID;
            this.RoomID = RoomID;
            this.ReservationDate = ReservationDate;
            this.NumberOfPeople = NumberOfPeople;
            this.Status = Status;
            this.LastStatusDate = LastStatusDate;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            ReservationPersonInfo = clsPerson.Find(ReservationPersonID);
            RoomInfo = clsRoom.Find(RoomID);
            CreatedByUserInfo = clsUser.Find(CreatedByUserID);
        }

        public static clsReservation Find(int ReservationID)
        {
            int ReservationPersonID = -1;
            int RoomID = -1;
            DateTime ReservationDate = DateTime.Now;
            byte NumberOfPeople = 1;
            byte Status = 1;
            DateTime LastStatusDate = DateTime.Now;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsReservationData.GetReservationInfoByID(ReservationID, ref ReservationPersonID, ref RoomID, ref ReservationDate, ref NumberOfPeople, ref Status, ref LastStatusDate, ref CreatedByUserID, ref CreatedDate);

            if (IsFound)
                return new clsReservation(ReservationID, ReservationPersonID, RoomID, ReservationDate, NumberOfPeople, (enReservationStatus)Status, LastStatusDate, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static bool IsReservationExist(int ReservationID)
        {
            return clsReservationData.IsReservationExist(ReservationID);
        }

        private bool _AddNewReservation()
        {
            ReservationID = clsReservationData.AddNewReservation(ReservationPersonID, RoomID, ReservationDate, NumberOfPeople, (byte)Status, LastStatusDate, CreatedByUserID, CreatedDate);
            return ReservationID != -1;
        }

        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservationInfo(ReservationID, ReservationPersonID, RoomID, ReservationDate, NumberOfPeople, (byte)Status, CreatedByUserID, CreatedDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateReservation();

            }
            return false;
        }

        public static bool DeleteReservation(int ReservationID)
        {
            return clsReservationData.DeleteReservation(ReservationID);
        }
     
        public static DataTable GetAllReservations()
        {
            return clsReservationData.GetAllReservations();
        }

        public static DataTable GetAllReservations(int ReservationPersonID)
        {
            return clsReservationData.GetAllReservations(ReservationPersonID);
        }

        public static bool IsRoomHasActiveReservationAt(int RoomID, DateTime ReservationDate)
        {
            return clsReservationData.IsRoomHasActiveReservationAt(RoomID, ReservationDate);
        }

        public bool CheckIn(int CreatedByUserID)
        {
            clsGuest Guest = clsGuest.Find(ReservationPersonID);

            int GuestID = -1;

            if (Guest == null)
            {
                Guest = new clsGuest();
                Guest.PersonID = ReservationPersonID;
                Guest.CreatedByUserID = CreatedByUserID;

                if (Guest.Save())
                {
                    GuestID = Guest.GuestID;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                GuestID = Guest.GuestID;
            }

            clsBooking Booking = new clsBooking();

            Booking.ReservationID = this.ReservationID;
            Booking.GuestID = GuestID;
            Booking.CheckInDate = this.ReservationDate;
            Booking.CheckInDate = this.ReservationDate.AddDays(1);
            Booking.Status = clsBooking.enStatus.Ongoing;
            Booking.CreatedByUserID = CreatedByUserID;

            if (!Booking.Save())
                return false;

            if (!this.RoomInfo.SetBooked())
                return false;

            return true;
        }

        public bool Confirm()
        {                  
            return clsReservationData.UpdateStatus(ReservationID, 2);
        }

        public bool Cancel()
        {
            return clsReservationData.UpdateStatus(ReservationID, 3);
        }

        public bool IsBookingConfirmed()
        {
            return clsBooking.IsBookingExistByReservationID(this.ReservationID);
        }

        public bool IsAllGuestCompanionsAdded()
        {
            if (NumberOfPeople == 1)
                return true;

            return clsBooking.IsAllGuestCompanionsAdded(this.ReservationID);
        }

        public bool IsReservationValid()
        {
            if (ReservationDate.Date.Year >= DateTime.Now.Year && ReservationDate.Date.Month >= DateTime.Now.Month)
                if (ReservationDate.Date.Day >= DateTime.Now.Day && Status == enReservationStatus.Pending)
                    return true;

            return false;
        }

        public bool IsTodayIsReservationDate()
        {
            return ReservationDate.Date.Day == DateTime.Today.Day;
        }

        public bool IsGuestCheckedIn()
        {
            return clsBooking.IsBookingExistByReservationID(ReservationID);
        }

        public static int GetReservationsCount()
        {
            return clsReservationData.GetReservationsCount();
        }

        public static int GetAvailableRoomType()
        {
            return clsReservationData.GetAvailableRoomType();
        }
    }
}
