using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsRoomType
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int RoomTypeID { get; private set; }
        public string RoomTypeTitle { get; set; }
        public byte RoomTypeCapacity { get; set; }
        public float RoomTypePricePerNight { get; set; }
        public string RoomTypeDescription { get; set; }

        public clsRoomType()
        {
            _Mode = enMode.AddNew;
            RoomTypeID = -1;
            RoomTypeTitle = "";
            RoomTypeCapacity = 1;
            RoomTypePricePerNight = 0;
            RoomTypeDescription = "";
        }
        private clsRoomType(int RoomTypeID, string RoomTypeTitle, byte RoomTypeCapacity, float RoomTypePricePerNight, string RoomTypeDescription)
        {
            _Mode = enMode.Update;
            this.RoomTypeID = RoomTypeID;
            this.RoomTypeTitle = RoomTypeTitle;
            this.RoomTypeCapacity = RoomTypeCapacity;
            this.RoomTypePricePerNight = RoomTypePricePerNight;
            this.RoomTypeDescription = RoomTypeDescription;
        }

        public static clsRoomType Find(int RoomTypeID)
        {
            string RoomTypeTitle = "";
            byte RoomTypeCapacity = 1;
            float RoomTypePricePerNight = 0;
            string RoomTypeDescription = "";

            bool IsFound = clsRoomTypeData.GetRoomTypeInfoByID(RoomTypeID, ref RoomTypeTitle, ref RoomTypeCapacity, ref RoomTypePricePerNight, ref RoomTypeDescription);

            if (IsFound)
                return new clsRoomType(RoomTypeID, RoomTypeTitle, RoomTypeCapacity, RoomTypePricePerNight, RoomTypeDescription);
            else
                return null;
        }

        public static bool IsRoomTypeExist(int RoomTypeID)
        {
            return clsRoomTypeData.IsRoomTypeExist(RoomTypeID);
        }

        public static clsRoomType Find(string RoomTypeTitle)
        {
            int RoomTypeID = -1;
            byte RoomTypeCapacity = 1;
            float RoomTypePricePerNight = 0;
            string RoomTypeDescription = "";

            bool IsFound = clsRoomTypeData.GetRoomTypeInfoByTitle(RoomTypeTitle,ref RoomTypeID, ref RoomTypeCapacity, ref RoomTypePricePerNight, ref RoomTypeDescription);

            if (IsFound)
                return new clsRoomType(RoomTypeID, RoomTypeTitle, RoomTypeCapacity, RoomTypePricePerNight, RoomTypeDescription);
            else
                return null;
        }

        public static bool IsRoomTypeExist(string RoomTypeTitle)
        {
            return clsRoomTypeData.IsRoomTypeExist(RoomTypeTitle);
        }

        private bool _AddNewRoomType()
        {
            RoomTypeID = clsRoomTypeData.AddNewRoomType(RoomTypeTitle, RoomTypeCapacity, RoomTypePricePerNight, RoomTypeDescription);
            return RoomTypeID != -1;
        }

        private bool _UpdateRoomType()
        {
            return clsRoomTypeData.UpdateRoomTypeInfo(RoomTypeID, RoomTypeTitle, RoomTypeCapacity, RoomTypePricePerNight, RoomTypeDescription);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoomType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRoomType();

            }
            return false;
        }

        public static bool DeleteRoomType(int RoomTypeID)
        {
            return clsRoomTypeData.DeleteRoomType(RoomTypeID);
        }

        public static DataTable GetAllRoomTypes()
        {
            return clsRoomTypeData.GetAllRoomTypes();
        }

        public static int GetRoomsCount(int RoomTypeID)
        {
            return clsRoom.GetRoomsCountPerRoomType(RoomTypeID);
        }

        public int GetRoomsCount()
        {
            return GetRoomsCount(RoomTypeID);
        }


    }
}
