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
    public class clsRoomTypeData
    {
        public static bool GetRoomTypeInfoByID(int RoomTypeID, ref string RoomTypeTitle, ref byte RoomTypeCapacity, ref float RoomTypePricePerNight, ref string RoomTypeDescription)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM RoomTypes 
                            WHERE RoomTypeID = @RoomTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    RoomTypeTitle = (string)reader["RoomTypeTitle"];
                    RoomTypeCapacity = (byte)reader["RoomTypeCapacity"];
                    RoomTypePricePerNight = Convert.ToSingle(reader["RoomTypePricePerNight"]);
                    // Handle null value for RoomTypeDescription since it allows null in the database
                    if (reader["RoomTypeDescription"] != DBNull.Value)
                        RoomTypeDescription = (string)reader["RoomTypeDescription"];
                    else
                        RoomTypeDescription = "";

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

        public static bool GetRoomTypeInfoByTitle(string RoomTypeTitle , ref int RoomTypeID, ref byte RoomTypeCapacity, ref float RoomTypePricePerNight, ref string RoomTypeDescription)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM RoomTypes 
                            WHERE RoomTypeTitle = @RoomTypeTitle;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeTitle", RoomTypeTitle);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    RoomTypeID = (int)reader["RoomTypeID"];
                    RoomTypeCapacity = (byte)reader["RoomTypeCapacity"];
                    RoomTypePricePerNight = Convert.ToSingle(reader["RoomTypePricePerNight"]);
                    // Handle null value for RoomTypeDescription since it allows null in the database
                    if (reader["RoomTypeDescription"] != DBNull.Value)
                        RoomTypeDescription = (string)reader["RoomTypeDescription"];
                    else
                        RoomTypeDescription = "";

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

        public static bool IsRoomTypeExist(int RoomTypeID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM RoomTypes
                             WHERE RoomTypeID = @RoomTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

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

        public static bool IsRoomTypeExist(string RoomTypeTitle)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM RoomTypes
                             WHERE RoomTypeTitle = @RoomTypeTitle;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeTitle", RoomTypeTitle);

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

        public static int AddNewRoomType(string RoomTypeTitle, byte RoomTypeCapacity, float RoomTypePricePerNight, string RoomTypeDescription)
        {
            //this function will return the newly added RoomTypeID if it was inserted successfully
            //otherwise it will return -1 

            int RoomTypeID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO RoomTypes (RoomTypeTitle,RoomTypeCapacity,RoomTypePricePerNight,RoomTypeDescription)
                            VALUES (@RoomTypeTitle,@RoomTypeCapacity,@RoomTypePricePerNight,@RoomTypeDescription);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeTitle", RoomTypeTitle);
            command.Parameters.AddWithValue("@RoomTypeCapacity", RoomTypeCapacity);
            command.Parameters.AddWithValue("@RoomTypePricePerNight", RoomTypePricePerNight);
            if (RoomTypeDescription != "" && RoomTypeDescription != null)
            {
                command.Parameters.AddWithValue("@RoomTypeDescription", RoomTypeDescription);
            }
            else
                command.Parameters.AddWithValue("@RoomTypeDescription", DBNull.Value);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new RoomTypeID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    RoomTypeID = InsertedID;
                }

                // Set RoomTypeID to -1 to indicate failure
                else
                    RoomTypeID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                RoomTypeID = -1;
            }

            finally
            {
                connection.Close();
            }

            return RoomTypeID;
        }

        public static bool UpdateRoomTypeInfo(int RoomTypeID, string RoomTypeTitle, byte RoomTypeCapacity, float RoomTypePricePerNight, string RoomTypeDescription)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE RoomTypes
                            SET 
							RoomTypeTitle = @RoomTypeTitle,
							RoomTypeCapacity = @RoomTypeCapacity,
							RoomTypePricePerNight = @RoomTypePricePerNight,
							RoomTypeDescription = @RoomTypeDescription
                            WHERE RoomTypeID = @RoomTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
            command.Parameters.AddWithValue("@RoomTypeTitle", RoomTypeTitle);
            command.Parameters.AddWithValue("@RoomTypeCapacity", RoomTypeCapacity);
            command.Parameters.AddWithValue("@RoomTypePricePerNight", RoomTypePricePerNight);
            if (RoomTypeDescription != "")
            {
                command.Parameters.AddWithValue("@RoomTypeDescription", RoomTypeDescription);
            }
            else
                command.Parameters.AddWithValue("@RoomTypeDescription", DBNull.Value);

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

        public static bool DeleteRoomType(int RoomTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE RoomTypes
                              WHERE RoomTypeID = @RoomTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

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

        public static DataTable GetAllRoomTypes()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RoomTypes.RoomTypeID as 'Room Type ID' , RoomTypeTitle as 'Room Type Title',
                            RoomTypeCapacity as 'Capacity' , RoomTypePricePerNight as 'Price Per Night',
                            (SELECT Count(*) FROM Rooms WHERE RoomTypes.RoomTypeID = Rooms.RoomTypeID) as 'Total Rooms'
                            FROM RoomTypes;";

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