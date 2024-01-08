using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsCountry
    {
        public int CountryID { set; get; }

        public string CountryName { set; get; }

        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = ""; 
        }

        private clsCountry(int CountryID , string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountryData.GetCountryInfoByID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryInfoByName(CountryName,ref CountryID))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}
