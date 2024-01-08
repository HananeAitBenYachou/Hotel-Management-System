using Hotel_DataAccessLayer.ErrorLogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int CountryID , ref string CountryName)
        {
            bool IsFound = false; 

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    CountryName = (string)reader["CountryName"];
                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch(Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int CountryID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    CountryID = (int)reader["CountryID"];
                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable DataTable = new DataTable(); 

            try
            {
                connection.Open();

                reader = command.ExecuteReader(); 

                if(reader.HasRows)
                {
                    DataTable.Load(reader); 
                }
            }

            catch(Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return DataTable;
        }

    }
}
