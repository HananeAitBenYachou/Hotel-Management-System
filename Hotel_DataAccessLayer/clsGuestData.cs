using Hotel_DataAccessLayer.ErrorLogs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer
{
    public class clsGuestData
    {
        public static bool GetGuestInfoByID(int GuestID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Guests 
                            WHERE GuestID = @GuestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                IsFound = false;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetGuestInfoByPersonID(int PersonID , ref int GuestID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Guests 
                            WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    GuestID = (int)reader["GuestID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                IsFound = false;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            return IsFound;
        }

        public static bool IsGuestExist(int GuestID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Guests
                             WHERE GuestID = @GuestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                IsFound = (reader != null);
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsGuestExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Guests
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                IsFound = (reader != null);
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewGuest(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            //this function will return the newly added GuestID if it was inserted successfully
            //otherwise it will return -1 

            int GuestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Guests (PersonID,CreatedByUserID,CreatedDate)
                            VALUES (@PersonID,@CreatedByUserID,@CreatedDate);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new GuestID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    GuestID = InsertedID;
                }

                // Set GuestID to -1 to indicate failure
                else
                    GuestID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                GuestID = -1;
            }

            finally
            {
                connection.Close();
            }

            return GuestID;
        }

        public static bool UpdateGuestInfo(int GuestID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Guests
                            SET 
							PersonID = @PersonID,
							CreatedByUserID = @CreatedByUserID,
							CreatedDate = @CreatedDate
                            WHERE GuestID = @GuestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected != 0;
        }

        public static bool DeleteGuest(int GuestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Guests
                              WHERE GuestID = @GuestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected != 0;
        }

        public static DataTable GetAllGuests()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT GuestID AS 'Guest ID' , People.PersonID AS 'Person ID' , NationalNo AS 'National No' , 
                            FirstName + ' ' + LastName AS 'Full Name', 
                            CASE 
	                            WHEN Gender = 'M' THEN 'Male'
	                            WHEN Gender = 'F' THEN 'Female'
	                            ELSE 'Unknown'
                            END AS 'Gender' ,
                            BirthDate AS 'Birth Date' , CountryName AS 'Nationality',
                            Phone , Email
                            FROM Guests
                            INNER JOIN People ON Guests.PersonID = People.PersonID
                            INNER JOIN Countries ON People.NationalityCountryID = 
                            Countries.CountryID;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return dataTable;
        }

        public static DataTable GetAllGuestCompanions(int GuestID , int BookingID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT GuestCompanionID AS 'Guest Companion ID' , NationalNo AS 'National No' , 
                            FirstName + ' ' + LastName AS 'Full Name', 
                            CASE 
	                            WHEN Gender = 'M' THEN 'Male'
	                            WHEN Gender = 'F' THEN 'Female'
	                            ELSE 'Unknown'
                            END AS 'Gender' ,
                            BirthDate AS 'Birth Date' , CountryName AS 'Nationality',
                            Phone , Email
                            FROM GuestCompanions
                            INNER JOIN People ON GuestCompanions.PersonID = People.PersonID
                            INNER JOIN Countries ON People.NationalityCountryID = 
                            Countries.CountryID
							WHERE GuestID = @GuestID AND BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@BookingID", BookingID);

            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                reader.Close();
                connection.Close();
            }

            return dataTable;
        }

        public static int GetGuestsCount()
        {
            int GuestsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(GuestID)
                            FROM Guests;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                GuestsCount = (int)reader;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return GuestsCount;
        }


    }
}
