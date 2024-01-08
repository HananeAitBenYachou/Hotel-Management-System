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
    public class clsOrderItemData
    {
        public static bool GetOrderItemInfoByID(int OrderItemID, ref int ItemID, ref int OrderID, ref int BookingID, ref byte Quantity, ref float Price)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM OrderItems 
                            WHERE OrderItemID = @OrderItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderItemID", OrderItemID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    ItemID = (int)reader["ItemID"];
                    OrderID = (int)reader["OrderID"];
                    BookingID = (int)reader["BookingID"];
                    Quantity = (byte)reader["Quantity"];
                    Price = Convert.ToSingle(reader["Price"]);
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

        public static bool IsOrderItemExist(int OrderItemID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM OrderItems
                             WHERE OrderItemID = @OrderItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderItemID", OrderItemID);

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

        public static int AddNewOrderItem(int ItemID, int OrderID, int BookingID, byte Quantity, float Price)
        {
            //this function will return the newly added OrderItemID if it was inserted successfully
            //otherwise it will return -1 

            int OrderItemID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO OrderItems (ItemID,OrderID,BookingID,Quantity,Price)
                            VALUES (@ItemID,@OrderID,@BookingID,@Quantity,@Price);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@Price", Price);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new OrderItemID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    OrderItemID = InsertedID;
                }

                // Set OrderItemID to -1 to indicate failure
                else
                    OrderItemID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                OrderItemID = -1;
            }

            finally
            {
                connection.Close();
            }

            return OrderItemID;
        }

        public static bool UpdateOrderItemInfo(int OrderItemID, int ItemID, int OrderID, int BookingID, byte Quantity, float Price)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE OrderItems
                            SET 
							ItemID = @ItemID,
							OrderID = @OrderID,
							BookingID = @BookingID,
							Quantity = @Quantity,
							Price = @Price
                            WHERE OrderItemID = @OrderItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderItemID", OrderItemID);
            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@Price", Price);

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

        public static bool DeleteOrderItem(int OrderItemID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE OrderItems
                              WHERE OrderItemID = @OrderItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderItemID", OrderItemID);

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

        public static DataTable GetAllOrderItems()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT OrderItemID AS 'Order Item ID', OrderID AS 'Order ID' , ItemID AS 'Item ID', 
                            BookingID AS 'Booking ID', Quantity , Price
                            FROM OrderItems;";

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

        public static DataTable GetAllOrderItems(int OrderID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT OrderItemID AS 'Order Item ID', OrderID AS 'Order ID' , ItemID AS 'Item ID', 
                            BookingID AS 'Booking ID', Quantity , Price
                            FROM OrderItems
                            WHERE OrderID = @OrderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", OrderID);


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
