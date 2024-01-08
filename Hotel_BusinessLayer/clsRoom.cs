using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsRoom
    {
        public enum enAvailabilityStatus {Available = 1, Booked = 2, UnderMaintenance = 3};
        
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int RoomID { get; private set; }
        public int RoomTypeID { get; set; }
        public clsRoomType RoomTypeInfo { get; }
        public string RoomNumber { get; set; }
        public byte RoomFloor { get; set; }
        public double RoomSize { get; set; }
        public enAvailabilityStatus AvailabilityStatus { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool IsPetFriendly { get; set; }
        public string AdditionalNotes { get; set; }

        public string AvailabilityStatusText
        {
            get
            {
                return GetAvailabilityStatus(AvailabilityStatus);
            }
        }

        public clsRoom()
        {
            _Mode = enMode.AddNew;
            RoomID = -1;
            RoomTypeID = -1;
            RoomNumber = "";
            RoomFloor = 0;
            RoomSize = 0;
            AvailabilityStatus = enAvailabilityStatus.Available;
            IsSmokingAllowed = false;
            IsPetFriendly = false;
            AdditionalNotes = "";
        }
        private clsRoom(int RoomID, int RoomTypeID, string RoomNumber, byte RoomFloor, double RoomSize, 
            enAvailabilityStatus AvailabilityStatus, bool IsSmokingAllowed, bool IsPetFriendly, string AdditionalNotes)
        {
            _Mode = enMode.Update;
            this.RoomID = RoomID;
            this.RoomTypeID = RoomTypeID;
            this.RoomNumber = RoomNumber;
            this.RoomFloor = RoomFloor;
            this.RoomSize = RoomSize;
            this.AvailabilityStatus = AvailabilityStatus;
            this.IsSmokingAllowed = IsSmokingAllowed;
            this.IsPetFriendly = IsPetFriendly;
            this.AdditionalNotes = AdditionalNotes;
            this.RoomTypeInfo = clsRoomType.Find(RoomTypeID);
        }

        public static clsRoom Find(int RoomID)
        {
            int RoomTypeID = -1;
            string RoomNumber = "";
            byte RoomFloor = 0;
            double RoomSize = 0;
            byte AvailabilityStatus = 0;
            bool IsSmokingAllowed = false;
            bool IsPetFriendly = false;
            string AdditionalNotes = "";

            bool IsFound = clsRoomData.GetRoomInfoByID(RoomID, ref RoomTypeID, ref RoomNumber, ref RoomFloor, ref RoomSize, ref AvailabilityStatus, ref IsSmokingAllowed, ref IsPetFriendly, ref AdditionalNotes);

            if (IsFound)
                return new clsRoom(RoomID, RoomTypeID, RoomNumber, RoomFloor, RoomSize, (enAvailabilityStatus)AvailabilityStatus, IsSmokingAllowed, IsPetFriendly, AdditionalNotes);
            else
                return null;
        }

        public static clsRoom Find(string RoomNumber)
        {
            int RoomID = -1;
            int RoomTypeID = -1;
            byte RoomFloor = 0;
            double RoomSize = 0;
            byte AvailabilityStatus = 0;
            bool IsSmokingAllowed = false;
            bool IsPetFriendly = false;
            string AdditionalNotes = "";

            bool IsFound = clsRoomData.GetRoomInfoByNumber(RoomNumber, ref RoomID, ref RoomTypeID, ref RoomFloor, ref RoomSize, ref AvailabilityStatus, ref IsSmokingAllowed, ref IsPetFriendly, ref AdditionalNotes);

            if (IsFound)
                return new clsRoom(RoomID, RoomTypeID, RoomNumber, RoomFloor, RoomSize, (enAvailabilityStatus)AvailabilityStatus, IsSmokingAllowed, IsPetFriendly, AdditionalNotes);
            else
                return null;
        }

        public static bool IsRoomExist(int RoomID)
        {
            return clsRoomData.IsRoomExist(RoomID);
        }

        public static bool IsRoomExist(string RoomNumber)
        {
            return clsRoomData.IsRoomExist(RoomNumber);
        }

        private bool _AddNewRoom()
        {
            RoomID = clsRoomData.AddNewRoom(RoomTypeID, RoomNumber, RoomFloor, RoomSize,(byte) AvailabilityStatus, IsSmokingAllowed, IsPetFriendly, AdditionalNotes);
            return RoomID != -1;
        }

        private bool _UpdateRoom()
        {
            return clsRoomData.UpdateRoomInfo(RoomID, RoomTypeID, RoomNumber, RoomFloor, RoomSize, (byte)AvailabilityStatus, IsSmokingAllowed, IsPetFriendly, AdditionalNotes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoom())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRoom();

            }
            return false;
        }

        public static bool DeleteRoom(int RoomID)
        {
            return clsRoomData.DeleteRoom(RoomID);
        }

        public static DataTable GetAllRooms()
        {
            return clsRoomData.GetAllRooms();
        }

        public static int GetRoomsCountPerRoomType(int RoomTypeID)
        {
            return clsRoomData.GetRoomsCountPerRoomType(RoomTypeID);
        }

        public static int GetRoomsCount()
        {
            return clsRoomData.GetRoomsCount();
        }

        public static int GetRoomsCountPerStatus(enAvailabilityStatus AvailabilityStatus)
        {
            return clsRoomData.GetRoomsCountPerStatus((byte)AvailabilityStatus);
        }

        public static string GetAvailabilityStatus(enAvailabilityStatus AvailabilityStatus)
        {
            switch(AvailabilityStatus)
            {
                case enAvailabilityStatus.Available:
                case enAvailabilityStatus.Booked:
                    return AvailabilityStatus.ToString();

                case enAvailabilityStatus.UnderMaintenance:
                    return "Under-Maintenance";
            }

            return enAvailabilityStatus.Available.ToString();
        }

        public static DataTable GetAvailableRoomsPerRoomType(int RoomTypeID)
        {
            return clsRoomData.GetRoomsPerRoomType(RoomTypeID,(int)enAvailabilityStatus.Available);
        }

        public bool SetBooked()
        {
            return clsRoomData.UpdateRoomAvailabilityStatus(RoomID, 2);
        }

        public bool SetAvailable()
        {
            return clsRoomData.UpdateRoomAvailabilityStatus(RoomID, 1);
        }

        public bool SetUnderMaintenance()
        {
            return clsRoomData.UpdateRoomAvailabilityStatus(RoomID, 3);
        }

    }
}
