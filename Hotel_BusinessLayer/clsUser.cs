using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int UserID { get; private set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            _Mode = enMode.AddNew;
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = true;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            _Mode = enMode.Update;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            PersonInfo = clsPerson.Find(PersonID);
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;

            string hashedPassword = clsPasswordUtility.ComputeHash(Password);

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName, hashedPassword, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUserInfo(UserID, PersonID, UserName, Password, IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public bool UpdatePassword(string NewPassword)
        {
            string hashedPassword = clsPasswordUtility.ComputeHash(NewPassword);

            return clsUserData.UpdateUserPassword(UserID, hashedPassword);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static int GetUsersCount()
        {
            return clsUserData.GetUsersCount();
        }

    }
}
