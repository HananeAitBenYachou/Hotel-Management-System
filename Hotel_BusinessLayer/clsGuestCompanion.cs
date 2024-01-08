using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsGuestCompanion
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int GuestCompanionID { get; private set; }
        public int PersonID { get; set; }
        public int GuestID { get; set; }
        public int BookingID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsGuestCompanion()
        {
            _Mode = enMode.AddNew;
            GuestCompanionID = -1;
            PersonID = -1;
            GuestID = -1;
            BookingID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }
        private clsGuestCompanion(int GuestCompanionID, int PersonID, int GuestID, int BookingID, int CreatedByUserID, DateTime CreatedDate)
        {
            _Mode = enMode.Update;
            this.GuestCompanionID = GuestCompanionID;
            this.PersonID = PersonID;
            this.GuestID = GuestID;
            this.BookingID = BookingID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        public static clsGuestCompanion Find(int GuestCompanionID)
        {
            int PersonID = -1;
            int GuestID = -1;
            int BookingID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsGuestCompanionData.GetGuestCompanionInfoByID(GuestCompanionID, ref PersonID, ref GuestID, ref BookingID, ref CreatedByUserID, ref CreatedDate);

            if (IsFound)
                return new clsGuestCompanion(GuestCompanionID, PersonID, GuestID, BookingID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static bool IsGuestCompanionExist(int GuestCompanionID)
        {
            return clsGuestCompanionData.IsGuestCompanionExist(GuestCompanionID);
        }

        public static bool IsGuestCompanionExist(int BookingID , int PersonID)
        {
            return clsGuestCompanionData.IsGuestCompanionExist(BookingID, PersonID);
        }

        private bool _AddNewGuestCompanion()
        {
            GuestCompanionID = clsGuestCompanionData.AddNewGuestCompanion(PersonID, GuestID, BookingID, CreatedByUserID, CreatedDate);
            return GuestCompanionID != -1;
        }

        private bool _UpdateGuestCompanion()
        {
            return clsGuestCompanionData.UpdateGuestCompanionInfo(GuestCompanionID, PersonID, GuestID, BookingID, CreatedByUserID, CreatedDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGuestCompanion())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateGuestCompanion();

            }
            return false;
        }

        public static bool DeleteGuestCompanion(int GuestCompanionID)
        {
            return clsGuestCompanionData.DeleteGuestCompanion(GuestCompanionID);
        }

        public static DataTable GetAllGuestCompanions()
        {
            return clsGuestCompanionData.GetAllGuestCompanions();
        }

        public static int GetGuestCompanionsCount()
        {
            return clsGuestCompanionData.GetGuestCompanionsCount();
        }
    }
}
