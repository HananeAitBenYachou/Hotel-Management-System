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
    public class clsBookingData
    {
        public static bool GetBookingInfoByID(int BookingID, ref int ReservationID, ref int GuestID, ref DateTime CheckInDate, ref DateTime? CheckOutDate, ref byte Status, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Bookings 
                            WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    ReservationID = (int)reader["ReservationID"];
                    GuestID = (int)reader["GuestID"];
                    CheckInDate = (DateTime)reader["CheckInDate"];

                    if (reader["CheckOutDate"] == System.DBNull.Value)
                        CheckOutDate = null;

                    else
                       CheckOutDate = (DateTime)reader["CheckOutDate"];

                    Status = (byte)reader["Status"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static bool GetBookingInfoByReservationID(int ReservationID , ref int BookingID, ref int GuestID, ref DateTime CheckInDate, ref DateTime? CheckOutDate, ref byte Status, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Bookings 
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
                    BookingID = (int)reader["BookingID"];
                    GuestID = (int)reader["GuestID"];
                    CheckInDate = (DateTime)reader["CheckInDate"];

                    if (reader["CheckOutDate"] == System.DBNull.Value)
                        CheckOutDate = null;

                    else
                        CheckOutDate = (DateTime)reader["CheckOutDate"];

                    Status = (byte)reader["Status"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static bool IsBookingExist(int BookingID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Bookings
                             WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static bool IsBookingExistByReservationID(int ReservationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Bookings
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

        public static int AddNewBooking(int ReservationID, int GuestID, DateTime CheckInDate, DateTime? CheckOutDate, byte Status, int CreatedByUserID)
        {
            //this function will return the newly added BookingID if it was inserted successfully
            //otherwise it will return -1 

            int BookingID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Bookings (ReservationID,GuestID,CheckInDate,CheckOutDate,Status,CreatedByUserID)
                            VALUES (@ReservationID,@GuestID,@CheckInDate,@CheckOutDate,@Status,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@CheckInDate", CheckInDate);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (CheckOutDate != null)
                command.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
            else
                command.Parameters.AddWithValue("@CheckOutDate", System.DBNull.Value);

            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new BookingID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    BookingID = InsertedID;
                }

                // Set BookingID to -1 to indicate failure
                else
                    BookingID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                BookingID = -1;
            }

            finally
            {
                connection.Close();
            }

            return BookingID;
        }

        public static bool UpdateBookingInfo(int BookingID, int ReservationID, int GuestID, DateTime CheckInDate, DateTime? CheckOutDate, byte Status, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Bookings
                            SET 
							ReservationID = @ReservationID,
							GuestID = @GuestID,
							CheckInDate = @CheckInDate,
							CheckOutDate = @CheckOutDate,
							Status = @Status,
							CreatedByUserID = @CreatedByUserID
                            WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@ReservationID", ReservationID);
            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@CheckInDate", CheckInDate);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (CheckOutDate != null)
                command.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
            else
                command.Parameters.AddWithValue("@CheckOutDate", System.DBNull.Value);

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

        public static bool DeleteBooking(int BookingID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Bookings
                              WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static DataTable GetAllBookings()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT BookingID as 'Booking ID' , Bookings.ReservationID as 'Reservation ID', FirstName + ' ' + LastName as 'Guest' ,
                            RoomNumber as 'Room Number', CheckInDate as 'Check In Date', CheckOutDate as 'Check Out Date' , 
                            NumberOfPeople as 'Total People',
                            CASE 
	                            WHEN Bookings.Status = 1 THEN 'Ongoing'
	                            WHEN Bookings.Status = 2 THEN 'Completed'
                            END AS 'Status'
                            FROM Bookings
                            INNER JOIN Reservations ON Reservations.ReservationID = Bookings.ReservationID
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

        public static DataTable GetAllGuestBookings(int GuestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT BookingID as 'Booking ID' , Bookings.ReservationID as 'Reservation ID', FirstName + ' ' + LastName as 'Guest' ,
                            RoomNumber as 'Room Number', CheckInDate as 'Check In Date', CheckOutDate as 'Check Out Date' , 
                            NumberOfPeople as 'Total People',
                            CASE 
	                            WHEN Bookings.Status = 1 THEN 'Ongoing'
	                            WHEN Bookings.Status = 2 THEN 'Completed'
                            END AS 'Status'
                            FROM Bookings
                            INNER JOIN Reservations ON Reservations.ReservationID = Bookings.ReservationID
                            INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID
                            INNER JOIN People ON Reservations.ReservationPersonID = People.PersonID
                            WHERE GuestID = @GuestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);

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

        public static bool IsAllGuestCompanionsAdded(int ReservationID)
        {
            bool IsAllGuestCompanionsAdded = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsAllGuestCompanionsAdded = 1 FROM 
                            (
                            SELECT NumberOfPeople as 'Reserved For' , 

                            (SELECT Count(GuestCompanions.GuestID) FROM GuestCompanions
                            WHERE GuestCompanions.GuestID = Bookings.GuestID) as 'Companions Count'

                            FROM Bookings
                            INNER JOIN Reservations ON Reservations.ReservationID = Bookings.ReservationID
                            WHERE Bookings.ReservationID = @ReservationID

                            )R1
                            WHERE R1.[Companions Count] = (R1.[Reserved For]-1);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReservationID", ReservationID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                IsAllGuestCompanionsAdded = (reader != null);
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return IsAllGuestCompanionsAdded;
        }

        public static bool CheckOut(int BookingID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Bookings
                            SET 
							CheckOutDate = @CheckOutDate,
							Status = 2
                            WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@CheckOutDate", DateTime.Now);
           
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

        public static bool IsBookingCompleted(int BookingID)
        {
            bool IsCompleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsCompleted = 1 
                             FROM Bookings
                             WHERE BookingID = @BookingID AND Status = 2;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                IsCompleted = (reader != null);
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return IsCompleted;
        }

        public static int GetBookingsCount()
        {
            int BookingsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(BookingID)
                            FROM Bookings;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                BookingsCount = (int)reader;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return BookingsCount;
        }

    }
}
