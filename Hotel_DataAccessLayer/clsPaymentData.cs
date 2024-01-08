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
    public class clsPaymentData
    {
        public static bool GetPaymentInfoByID(int PaymentID, ref int BookingID, ref DateTime PaymentDate, ref float PaidAmount, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM Payments 
                            WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
                    PaymentDate = (DateTime)reader["PaymentDate"];
                    PaidAmount = Convert.ToSingle(reader["PaidAmount"]);
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

        public static bool IsPaymentExist(int PaymentID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM Payments
                             WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static int AddNewPayment(int BookingID, DateTime PaymentDate, float PaidAmount, int CreatedByUserID)
        {
            //this function will return the newly added PaymentID if it was inserted successfully
            //otherwise it will return -1 

            int PaymentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Payments (BookingID,PaymentDate,PaidAmount,CreatedByUserID)
                            VALUES (@BookingID,@PaymentDate,@PaidAmount,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new PaymentID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    PaymentID = InsertedID;
                }

                // Set PaymentID to -1 to indicate failure
                else
                    PaymentID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                PaymentID = -1;
            }

            finally
            {
                connection.Close();
            }

            return PaymentID;
        }

        public static bool UpdatePaymentInfo(int PaymentID, int BookingID, DateTime PaymentDate, float PaidAmount, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Payments
                            SET 
							BookingID = @BookingID,
							PaymentDate = @PaymentDate,
							PaidAmount = @PaidAmount,
							CreatedByUserID = @CreatedByUserID
                            WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Payments
                              WHERE PaymentID = @PaymentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static DataTable GetAllPayments()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT PaymentID AS 'Payment ID' , Payments.BookingID AS 'Booking ID' ,
                            FirstName+ ' ' + LastName AS 'Guest Name',
                            PaymentDate AS 'Payment Date' , PaidAmount AS 'Paid Amount' 
                            FROM Payments
                            INNER JOIN Bookings ON Bookings.BookingID = Payments.BookingID
                            INNER JOIN Guests ON Bookings.GuestID = Guests.GuestID
                            INNER JOIN People ON People.PersonID = Guests.PersonID;";

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

        public static DataTable GetAllPayments(int GuestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT PaymentID AS 'Payment ID' , Payments.BookingID AS 'Booking ID' ,
                            FirstName+ ' ' + LastName AS 'Guest Name',
                            PaymentDate AS 'Payment Date' , PaidAmount AS 'Paid Amount' 
                            FROM Payments
                            INNER JOIN Bookings ON Bookings.BookingID = Payments.BookingID
                            INNER JOIN Guests ON Bookings.GuestID = Guests.GuestID
                            INNER JOIN People ON People.PersonID = Guests.PersonID
							WHERE Guests.GuestID = @GuestID;";

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

        public static int GetPaymentsCount()
        {
            int PaymentsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(PaymentID)
                            FROM Payments;";

            SqlCommand command = new SqlCommand(query, connection);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                PaymentsCount = (int)reader;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return PaymentsCount;
        }

    }
}
