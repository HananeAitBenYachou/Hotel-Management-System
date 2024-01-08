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
    public class clsRoomServiceData
    {
        public static bool GetRoomServiceInfoByID(int RoomServiceID, ref string RoomServiceTitle, ref string RoomServiceDescription, ref float RoomServiceFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM RoomServices 
                            WHERE RoomServiceID = @RoomServiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    RoomServiceTitle = (string)reader["RoomServiceTitle"];
                    RoomServiceDescription = (string)reader["RoomServiceDescription"];
                    RoomServiceFees = Convert.ToSingle(reader["RoomServiceFees"]);
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

        public static bool IsRoomServiceExist(int RoomServiceID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM RoomServices
                             WHERE RoomServiceID = @RoomServiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);

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

        public static bool IsRoomServiceExist(string RoomServiceTitle)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM RoomServices
                             WHERE RoomServiceTitle = @RoomServiceTitle;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceTitle", RoomServiceTitle);

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

        public static int AddNewRoomService(string RoomServiceTitle, string RoomServiceDescription, float RoomServiceFees)
        {
            //this function will return the newly added RoomServiceID if it was inserted successfully
            //otherwise it will return -1 

            int RoomServiceID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO RoomServices (RoomServiceTitle,RoomServiceDescription,RoomServiceFees)
                            VALUES (@RoomServiceTitle,@RoomServiceDescription,@RoomServiceFees);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceTitle", RoomServiceTitle);
            command.Parameters.AddWithValue("@RoomServiceDescription", RoomServiceDescription);
            command.Parameters.AddWithValue("@RoomServiceFees", RoomServiceFees);

            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new RoomServiceID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    RoomServiceID = InsertedID;
                }

                // Set RoomServiceID to -1 to indicate failure
                else
                    RoomServiceID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                RoomServiceID = -1;
            }

            finally
            {
                connection.Close();
            }

            return RoomServiceID;
        }

        public static bool UpdateRoomServiceInfo(int RoomServiceID, string RoomServiceTitle, string RoomServiceDescription, float RoomServiceFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE RoomServices
                            SET 
							RoomServiceTitle = @RoomServiceTitle,
							RoomServiceDescription = @RoomServiceDescription,
							RoomServiceFees = @RoomServiceFees
                            WHERE RoomServiceID = @RoomServiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);
            command.Parameters.AddWithValue("@RoomServiceTitle", RoomServiceTitle);
            command.Parameters.AddWithValue("@RoomServiceDescription", RoomServiceDescription);
            command.Parameters.AddWithValue("@RoomServiceFees", RoomServiceFees);

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

        public static bool DeleteRoomService(int RoomServiceID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE RoomServices
                              WHERE RoomServiceID = @RoomServiceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);

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

        public static DataTable GetAllRoomServices()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RoomServiceID AS 'Room Service ID' , RoomServiceTitle AS 'Room Service Title',
                            RoomServiceFees AS 'Fees' ,RoomServiceDescription AS 'Description'
                            FROM RoomServices;";

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

    }
}
