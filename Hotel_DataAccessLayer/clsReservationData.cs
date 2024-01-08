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
    public class clsReservationData
    {
        public static bool GetReservationInfoByID(int ReservationID, ref int ReservationPersonID, ref int RoomID, ref DateTime ReservationDate, ref byte NumberOfPeople, ref byte Status, ref DateTime LastStatusDate, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Reservations 
                            WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    ReservationPersonID = (int)reader["ReservationPersonID"];
                    RoomID = (int)reader["RoomID"];
                    ReservationDate = (DateTime)reader["ReservationDate"];
                    NumberOfPeople = (byte)reader["NumberOfPeople"];
                    Status = (byte)reader["Status"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
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

        public static bool IsReservationExist(int ReservationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Reservations
                             WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

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

        public static int AddNewReservation(int ReservationPersonID, int RoomID, DateTime ReservationDate, byte NumberOfPeople, byte Status, DateTime LastStatusDate, int CreatedByUserID, DateTime CreatedDate)
        {
            //this function will return the newly added ReservationID if it was inserted successfully
            //otherwise it will return -1 

            int ReservationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Reservations (ReservationPersonID,RoomID,ReservationDate,NumberOfPeople,Status,LastStatusDate,CreatedByUserID,CreatedDate)
                            VALUES (@ReservationPersonID,@RoomID,@ReservationDate,@NumberOfPeople,@Status,@LastStatusDate,@CreatedByUserID,@CreatedDate);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationPersonID", ReservationPersonID);
            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
            command.Parameters.AddWithValue("@NumberOfPeople", NumberOfPeople);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new ReservationID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    ReservationID = InsertedID;
                }

                // Set ReservationID to -1 to indicate failure
                else
                    ReservationID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                ReservationID = -1;
            }

            finally
            {
                connection.Close();
            }

            return ReservationID;
        }

        public static bool UpdateReservationInfo(int ReservationID, int ReservationPersonID, int RoomID, DateTime ReservationDate, byte NumberOfPeople, byte Status, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Reservations
                            SET 
							ReservationPersonID = @ReservationPersonID,
							RoomID = @RoomID,
							ReservationDate = @ReservationDate,
							NumberOfPeople = @NumberOfPeople,
							Status = @Status,
							LastStatusDate = @LastStatusDate,
							CreatedByUserID = @CreatedByUserID,
							CreatedDate = @CreatedDate
                            WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@ReservationPersonID", ReservationPersonID);
            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
            command.Parameters.AddWithValue("@NumberOfPeople", NumberOfPeople);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
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

        public static bool DeleteReservation(int ReservationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Reservations
                              WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

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

        public static DataTable GetAllReservations()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ReservationID as 'Reservation ID' , FirstName + ' ' + LastName as 'Reserved By' ,
                            RoomNumber as 'Room Number', ReservationDate as 'Reservation Date', NumberOfPeople as 'Number Of People',
                            CASE 
								WHEN CONVERT(date, ReservationDate) <  CONVERT(date, GETDATE()) 
								AND Status = 1 THEN 'Invalid'
	                            WHEN Status = 1 THEN 'Pending'
	                            WHEN Status = 2 THEN 'Confirmed'
	                            WHEN Status = 3 THEN 'Cancelled'
                            END AS 'Status'
                            FROM Reservations
                            INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID
                            INNER JOIN People ON Reservations.ReservationPersonID = People.PersonID;";

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

        public static DataTable GetAllReservations(int ReservationPersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ReservationID as 'Reservation ID' , FirstName + ' ' + LastName as 'Reserved By' ,
                            RoomNumber as 'Room Number', ReservationDate as 'Reservation Date', NumberOfPeople as 'Number Of People',
                            CASE 
								WHEN CONVERT(date, ReservationDate) <  CONVERT(date, GETDATE())
								AND Status = 1 THEN 'Invalid'
	                            WHEN Status = 1 THEN 'Pending'
	                            WHEN Status = 2 THEN 'Confirmed'
	                            WHEN Status = 3 THEN 'Cancelled'
                            END AS 'Status'
                            FROM Reservations
                            INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID
                            INNER JOIN People ON Reservations.ReservationPersonID = People.PersonID
                            WHERE ReservationPersonID = @ReservationPersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationPersonID", ReservationPersonID);

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

        public static bool IsRoomHasActiveReservationAt(int RoomID , DateTime ReservationDate)
        {
            bool IsRoomHasActiveReservation = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsRoomHasActiveReservation = 1
                            FROM Reservations
                            WHERE RoomID = @RoomID AND Status != 3
                            AND CONVERT(date,ReservationDate) = CONVERT(date, @ReservationDate);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@ReservationDate", ReservationDate);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                IsRoomHasActiveReservation = (reader != null);
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return IsRoomHasActiveReservation;
        }

        public static bool UpdateStatus(int ReservationID, byte Status)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Reservations
                            SET 
							Status = @Status,
							LastStatusDate = @LastStatusDate
                            WHERE ReservationID = @ReservationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            command.Parameters.AddWithValue("@ReservationID", ReservationID);


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

        public static int GetReservationsCount()
        {
            int ReservationsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(ReservationID)
                            FROM Reservations;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                ReservationsCount = (int)reader;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return ReservationsCount;
        }

        public static int GetAvailableRoomType()
        {
            int RoomTypeID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 RoomTypes.RoomTypeID 
                            FROM RoomTypes
                            INNER JOIN Rooms ON Rooms.RoomTypeID = RoomTypes.RoomTypeID
                            WHERE AvailabilityStatus = 1
                            ORDER BY RoomTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                RoomTypeID = reader != null ? (int)reader : 0;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return RoomTypeID;
        }

    }
}
