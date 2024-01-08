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
    public class clsRoomData
    {
        public static bool GetRoomInfoByID(int RoomID, ref int RoomTypeID, ref string RoomNumber, ref byte RoomFloor, ref double RoomSize, ref byte AvailabilityStatus, ref bool IsSmokingAllowed, ref bool IsPetFriendly, ref string AdditionalNotes)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Rooms 
                            WHERE RoomID = @RoomID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);

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
                    RoomNumber = (string)reader["RoomNumber"];
                    RoomFloor = (byte)reader["RoomFloor"];
                    RoomSize = Convert.ToDouble(reader["RoomSize"]);
                    AvailabilityStatus = (byte)reader["AvailabilityStatus"];
                    IsSmokingAllowed = (bool)reader["IsSmokingAllowed"];
                    IsPetFriendly = (bool)reader["IsPetFriendly"];
                    // Handle null value for AdditionalNotes since it allows null in the database
                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";

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

        public static bool GetRoomInfoByNumber(string RoomNumber , ref int RoomID, ref int RoomTypeID, ref byte RoomFloor, ref double RoomSize, ref byte AvailabilityStatus, ref bool IsSmokingAllowed, ref bool IsPetFriendly, ref string AdditionalNotes)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Rooms 
                            WHERE RoomNumber = @RoomNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    RoomID = (int)reader["RoomID"];
                    RoomTypeID = (int)reader["RoomTypeID"];
                    RoomFloor = (byte)reader["RoomFloor"];
                    RoomSize = Convert.ToDouble(reader["RoomSize"]);
                    AvailabilityStatus = (byte)reader["AvailabilityStatus"];
                    IsSmokingAllowed = (bool)reader["IsSmokingAllowed"];
                    IsPetFriendly = (bool)reader["IsPetFriendly"];
                    // Handle null value for AdditionalNotes since it allows null in the database
                    if (reader["AdditionalNotes"] != DBNull.Value)
                        AdditionalNotes = (string)reader["AdditionalNotes"];
                    else
                        AdditionalNotes = "";

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

        public static bool IsRoomExist(int RoomID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Rooms
                             WHERE RoomID = @RoomID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);

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

        public static bool IsRoomExist(string RoomNumber)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Rooms
                             WHERE RoomNumber = @RoomNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);

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

        public static int AddNewRoom(int RoomTypeID, string RoomNumber, byte RoomFloor, double RoomSize, byte AvailabilityStatus, bool IsSmokingAllowed, bool IsPetFriendly, string AdditionalNotes)
        {
            //this function will return the newly added RoomID if it was inserted successfully
            //otherwise it will return -1 

            int RoomID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Rooms (RoomTypeID,RoomNumber,RoomFloor,RoomSize,AvailabilityStatus,IsSmokingAllowed,IsPetFriendly,AdditionalNotes)
                            VALUES (@RoomTypeID,@RoomNumber,@RoomFloor,@RoomSize,@AvailabilityStatus,@IsSmokingAllowed,@IsPetFriendly,@AdditionalNotes);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            command.Parameters.AddWithValue("@RoomFloor", RoomFloor);
            command.Parameters.AddWithValue("@RoomSize", RoomSize);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
            command.Parameters.AddWithValue("@IsSmokingAllowed", IsSmokingAllowed);
            command.Parameters.AddWithValue("@IsPetFriendly", IsPetFriendly);
            if (AdditionalNotes != "" && AdditionalNotes != null)
            {
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            }
            else
                command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new RoomID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    RoomID = InsertedID;
                }

                // Set RoomID to -1 to indicate failure
                else
                    RoomID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                RoomID = -1;
            }

            finally
            {
                connection.Close();
            }

            return RoomID;
        }

        public static bool UpdateRoomInfo(int RoomID, int RoomTypeID, string RoomNumber, byte RoomFloor, double RoomSize, byte AvailabilityStatus, bool IsSmokingAllowed, bool IsPetFriendly, string AdditionalNotes)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Rooms
                            SET 
							RoomTypeID = @RoomTypeID,
							RoomNumber = @RoomNumber,
							RoomFloor = @RoomFloor,
							RoomSize = @RoomSize,
							AvailabilityStatus = @AvailabilityStatus,
							IsSmokingAllowed = @IsSmokingAllowed,
							IsPetFriendly = @IsPetFriendly,
							AdditionalNotes = @AdditionalNotes
                            WHERE RoomID = @RoomID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            command.Parameters.AddWithValue("@RoomFloor", RoomFloor);
            command.Parameters.AddWithValue("@RoomSize", RoomSize);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
            command.Parameters.AddWithValue("@IsSmokingAllowed", IsSmokingAllowed);
            command.Parameters.AddWithValue("@IsPetFriendly", IsPetFriendly);
            if (AdditionalNotes != "")
            {
                command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);
            }
            else
                command.Parameters.AddWithValue("@AdditionalNotes", DBNull.Value);

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

        public static bool DeleteRoom(int RoomID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Rooms
                              WHERE RoomID = @RoomID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);

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

        public static DataTable GetAllRooms()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RoomID AS 'Room ID', RoomTypeTitle AS 'Room Type' , RoomNumber AS 'Room Number',
                            RoomFloor AS 'Floor Number' , RoomSize AS 'Size' , 
                            CASE
	                            WHEN AvailabilityStatus = 1 THEN 'Available' 
	                            WHEN AvailabilityStatus = 2 THEN 'Booked' 
	                            ELSE 'Under Maintenance' 
                            END AS 'Status', IsSmokingAllowed AS 'Is Smoking Allowed' , IsPetFriendly AS 'Is PetFriendly', AdditionalNotes AS 'Notes'
                            FROM Rooms
                            INNER JOIN RoomTypes ON RoomTypes.RoomTypeID = Rooms.RoomTypeID;";

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

        public static int GetRoomsCountPerRoomType(int RoomTypeID)
        {
            int RoomsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Count(*) FROM Rooms WHERE RoomTypeID = @RoomTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);

            object RowsCount = null;

            try
            {
                connection.Open();
                RowsCount = command.ExecuteScalar();

                if (RowsCount != null && int.TryParse(RowsCount.ToString(), out int Count))
                {
                    RoomsCount = Count;
                }
                else
                    RoomsCount = 0;
            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }
            return RoomsCount;
        }

        public static int GetRoomsCount()
        {
            int RoomsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(RoomID) FROM Rooms;";

            SqlCommand command = new SqlCommand(query, connection);

            object RowsCount = null;

            try
            {
                connection.Open();
                RowsCount = command.ExecuteScalar();

                if (RowsCount != null && int.TryParse(RowsCount.ToString(), out int Count))
                {
                    RoomsCount = Count;
                }
                else
                    RoomsCount = 0;
            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }
            return RoomsCount;
        }

        public static int GetRoomsCountPerStatus(byte AvailabilityStatus)
        {
            int RoomsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(RoomID) FROM Rooms
                            WHERE AvailabilityStatus = @AvailabilityStatus;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);

            object RowsCount = null;

            try
            {
                connection.Open();
                RowsCount = command.ExecuteScalar();

                if (RowsCount != null && int.TryParse(RowsCount.ToString(), out int Count))
                {
                    RoomsCount = Count;
                }
                else
                    RoomsCount = 0;
            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }
            return RoomsCount;
        }

        public static DataTable GetRoomsPerRoomType(int RoomTypeID, byte AvailabilityStatus)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RoomID,RoomNumber 
                            FROM Rooms
                            WHERE RoomTypeID = @RoomTypeID AND AvailabilityStatus = @AvailabilityStatus;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);

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

        public static bool UpdateRoomAvailabilityStatus(int RoomID, byte AvailabilityStatus)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Rooms
                            SET 
							AvailabilityStatus = @AvailabilityStatus
                            WHERE RoomID = @RoomID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
            
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

    }
}
