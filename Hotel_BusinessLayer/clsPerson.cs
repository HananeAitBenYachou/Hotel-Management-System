using Hotel_DataAccessLayer;
using System;
using System.Data;

namespace Hotel_BusinessLayer
{
    public class clsPerson
    {
        private enum _enMode { AddNew = 0 , Update = 1};
        private _enMode _Mode = _enMode.AddNew;

        public int PersonID { private set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string NationalNo { set; get; }
        public char Gender { set; get; }
        public DateTime BirthDate { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public int NationalityCountryID { set; get; }
        public string PersonalImagePath { set; get; }
        public clsCountry CountryInfo { get;}

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.Gender = ' ';
            this.BirthDate = DateTime.Now;
            this.Email = "";
            this.Address = "";
            this.Phone = "";
            this.NationalityCountryID = -1;
            this.PersonalImagePath = "";

            _Mode = _enMode.AddNew;
        }

        private clsPerson(int PersonID , string FirstName , string LastName , string NationalNo,
             char Gender, DateTime BirthDate, string Address, string Phone,
             string Email, int NationalityCountryID, string PersonalImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Gender = Gender;
            this.BirthDate = BirthDate;
            this.Email = Email;
            this.Address = Address;
            this.Phone = Phone;
            this.NationalityCountryID = NationalityCountryID;
            this.PersonalImagePath = PersonalImagePath;

            CountryInfo = clsCountry.Find(NationalityCountryID);
            _Mode = _enMode.Update;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", LastName = "", NationalNo = "", Address = "", Phone = "", Email = "", PersonalImagePath = "";
            char Gender = ' ';
            int NationalityCountryID = -1;
            DateTime BirthDate = DateTime.Now;

            bool IsFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref NationalNo,
            ref Gender, ref BirthDate, ref Address, ref Phone,
            ref Email, ref NationalityCountryID, ref PersonalImagePath);

            if (IsFound)
                return new clsPerson(PersonID, FirstName, LastName, NationalNo,Gender, BirthDate, Address, Phone,
                                     Email, NationalityCountryID, PersonalImagePath);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", LastName = "", Address = "", Phone = "", Email = "", PersonalImagePath = "";
            char Gender = ' ';
            int PersonID = -1 , NationalityCountryID = -1;
            DateTime BirthDate = DateTime.Now;

            bool IsFound = clsPersonData.GetPersonInfoByNationalNo(NationalNo ,ref PersonID, ref FirstName, ref LastName,
            ref Gender, ref BirthDate, ref Address, ref Phone,
            ref Email, ref NationalityCountryID, ref PersonalImagePath);

            if (IsFound)
                return new clsPerson(PersonID, FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone,
                                     Email, NationalityCountryID, PersonalImagePath);
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone,
                                     Email, NationalityCountryID, PersonalImagePath);

            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID ,FirstName, LastName, NationalNo, Gender, BirthDate, Address, Phone,
                                     Email, NationalityCountryID, PersonalImagePath);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case _enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    break;

                case _enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }
    }
}
