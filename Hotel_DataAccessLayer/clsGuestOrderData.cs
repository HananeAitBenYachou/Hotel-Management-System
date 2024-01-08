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
    public class clsGuestOrderData
    {
        public static bool GetGuestOrderInfoByID(int GuestOrderID, ref int GuestID, ref int RoomID, ref DateTime OrderDate, ref int CreatedByUserID, 
            ref int BookingID, ref byte OrderType , ref int? RoomServiceID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM GuestOrders 
                            WHERE GuestOrderID = @GuestOrderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestOrderID", GuestOrderID);

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
                    RoomID = (int)reader["RoomID"];
                    OrderDate = (DateTime)reader["OrderDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    BookingID = (int)reader["BookingID"];
                    OrderType = (byte)reader["OrderType"];
                    if (reader["RoomServiceID"] != DBNull.Value)
                        RoomServiceID = (int?)reader["RoomServiceID"];
                    else
                        RoomServiceID = null;
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

        public static bool IsGuestOrderExist(int GuestOrderID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM GuestOrders
                             WHERE GuestOrderID = @GuestOrderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestOrderID", GuestOrderID);

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

        public static int AddNewGuestOrder(int GuestID, int RoomID, DateTime OrderDate, int CreatedByUserID, int BookingID, 
            byte OrderType, int? RoomServiceID)
        {
            //this function will return the newly added GuestOrderID if it was inserted successfully
            //otherwise it will return -1 

            int GuestOrderID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO GuestOrders (GuestID,RoomID,OrderDate,CreatedByUserID,BookingID,OrderType,RoomServiceID)
                            VALUES (@GuestID,@RoomID,@OrderDate,@CreatedByUserID,@BookingID,@OrderType,@RoomServiceID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@OrderType", OrderType);

            if (RoomServiceID != null)
            {
                command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);
            }
            else
                command.Parameters.AddWithValue("@RoomServiceID", DBNull.Value);

            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new GuestOrderID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    GuestOrderID = InsertedID;
                }

                // Set GuestOrderID to -1 to indicate failure
                else
                    GuestOrderID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                GuestOrderID = -1;
            }

            finally
            {
                connection.Close();
            }

            return GuestOrderID;
        }

        public static bool UpdateGuestOrderInfo(int GuestOrderID, int GuestID, int RoomID, DateTime OrderDate, int CreatedByUserID, int BookingID, 
            byte OrderType, int? RoomServiceID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE GuestOrders
                            SET 
							GuestID = @GuestID,
							RoomID = @RoomID,
							OrderDate = @OrderDate,
							CreatedByUserID = @CreatedByUserID,
							BookingID = @BookingID,
							OrderType = @OrderType,
                            RoomServiceID = @RoomServiceID
                            WHERE GuestOrderID = @GuestOrderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestOrderID", GuestOrderID);
            command.Parameters.AddWithValue("@GuestID", GuestID);
            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@OrderType", OrderType);

            if (RoomServiceID != null)
            {
                command.Parameters.AddWithValue("@RoomServiceID", RoomServiceID);
            }
            else
                command.Parameters.AddWithValue("@RoomServiceID", DBNull.Value);

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

        public static bool DeleteGuestOrder(int GuestOrderID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE GuestOrders
                              WHERE GuestOrderID = @GuestOrderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestOrderID", GuestOrderID);

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

        public static DataTable GetAllGuestOrders()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT [Order ID] , [Guest Name] , [Booking ID] , [Room Number] ,
                            [Order Type] , [Fees], [Order Date]
                            FROM GuestOrders_View ;";

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

        public static DataTable GetAllGuestOrders(int GuestID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT [Order ID] , [Guest Name] , [Booking ID] , [Room Number] ,
                            [Order Type] , [Fees], [Order Date]
                            FROM GuestOrders_View 
                            INNER JOIN Bookings ON Bookings.BookingID = [Booking ID] 
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

        public static int GetGuestOrdersCount()
        {
            int OrdersCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(GuestOrderID) FROM GuestOrders;";

            SqlCommand command = new SqlCommand(query, connection);

            object RowsCount = null;

            try
            {
                connection.Open();
                RowsCount = command.ExecuteScalar();

                if (RowsCount != null && int.TryParse(RowsCount.ToString(), out int Count))
                {
                    OrdersCount = Count;
                }
                else
                    OrdersCount = 0;
            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }
            return OrdersCount;
        }

        public static float GetOrderPaidFees(int GuestOrderID)
        {
            float PaidFees = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"IF((SELECT OrderType FROM GuestOrders WHERE GuestOrderID = @GuestOrderID) = 1)
                            BEGIN
                                SELECT RoomServiceFees AS 'Fees'
                                FROM GuestOrders
	                            INNER JOIN RoomServices On GuestOrders.RoomServiceID = RoomServices.RoomServiceID
	                            WHERE GuestOrderID = @GuestOrderID
                            END
                            ELSE
                            BEGIN
                                SELECT SUM(Price) AS 'Fees'
	                            FROM OrderItems
	                            WHERE OrderItems.OrderID = @GuestOrderID
                            END;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GuestOrderID", GuestOrderID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();
                PaidFees = reader != null ? Convert.ToSingle(reader) : 0;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }

            finally
            {
                connection.Close();
            }

            return PaidFees;
        }


    }
}
