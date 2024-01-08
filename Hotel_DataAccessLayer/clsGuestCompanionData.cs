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
    public class clsGuestCompanionData
    {
        public static bool GetGuestCompanionInfoByID(int GuestCompanionID, ref int PersonID, ref int GuestID, ref int BookingID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM GuestCompanions 
                            WHERE GuestCompanionID = @GuestCompanionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestCompanionID", GuestCompanionID);

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
                    GuestID = (int)reader["GuestID"];
                    BookingID = (int)reader["BookingID"];
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

        public static bool IsGuestCompanionExist(int GuestCompanionID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM GuestCompanions
                             WHERE GuestCompanionID = @GuestCompanionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestCompanionID", GuestCompanionID);

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

        public static bool IsGuestCompanionExist(int BookingID , int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM GuestCompanions
                             WHERE BookingID = @BookingID AND PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);
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

        public static int AddNewGuestCompanion(int PersonID, int GuestID, int BookingID, int CreatedByUserID, DateTime CreatedDate)
        {
            //this function will return the newly added GuestCompanionID if it was inserted successfully
            //otherwise it will return -1 

            int GuestCompanionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO GuestCompanions (PersonID,GuestID,BookingID,CreatedByUserID,CreatedDate)
                            VALUES (@PersonID,@GuestID,@BookingID,@CreatedByUserID,@CreatedDate);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new GuestCompanionID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    GuestCompanionID = InsertedID;
                }

                // Set GuestCompanionID to -1 to indicate failure
                else
                    GuestCompanionID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                GuestCompanionID = -1;
            }

            finally
            {
                connection.Close();
            }

            return GuestCompanionID;
        }

        public static bool UpdateGuestCompanionInfo(int GuestCompanionID, int PersonID, int GuestID, int BookingID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE GuestCompanions
                            SET 
							PersonID = @PersonID,
							GuestID = @GuestID,
							BookingID = @BookingID,
							CreatedByUserID = @CreatedByUserID,
							CreatedDate = @CreatedDate
                            WHERE GuestCompanionID = @GuestCompanionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestCompanionID", GuestCompanionID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
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

        public static bool DeleteGuestCompanion(int GuestCompanionID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE GuestCompanions
                              WHERE GuestCompanionID = @GuestCompanionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestCompanionID", GuestCompanionID);

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

        public static DataTable GetAllGuestCompanions()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM GuestCompanions;";

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

        public static DataTable GetAllGuestCompanions(int BookingID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM GuestCompanions WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static int GetGuestCompanionsCount()
        {
            int GuestCompanionsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(GuestCompanionID)
                            FROM GuestCompanions;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                GuestCompanionsCount = (int)reader;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return GuestCompanionsCount;
        }


    }
}
