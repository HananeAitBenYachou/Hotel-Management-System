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
    public class clsMenuItemData
    {
        public static bool GetMenuItemInfoByID(int ItemID, ref string ItemName, ref byte ItemType, ref float Price, ref string Description, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * 
                            FROM MenuItems 
                            WHERE ItemID = @ItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    ItemName = (string)reader["ItemName"];
                    ItemType = (byte)reader["ItemType"];
                    Price = Convert.ToSingle(reader["Price"]);
                    // Handle null value for Description since it allows null in the database
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = "";
                    // Handle null value for ImagePath since it allows null in the database
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static bool IsMenuItemExist(int ItemID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM MenuItems
                             WHERE ItemID = @ItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);

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

        public static bool IsMenuItemExist(string ItemName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT IsFound = 1 
                             FROM MenuItems
                             WHERE ItemName = @ItemName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", ItemName);

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

        public static int AddNewMenuItem(string ItemName, byte ItemType, float Price, string Description, string ImagePath)
        {
            //this function will return the newly added ItemID if it was inserted successfully
            //otherwise it will return -1 

            int ItemID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO MenuItems (ItemName,ItemType,Price,Description,ImagePath)
                            VALUES (@ItemName,@ItemType,@Price,@Description,@ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@ItemType", ItemType);
            command.Parameters.AddWithValue("@Price", Price);
            if (Description != "" && Description != null)
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new ItemID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                {
                    ItemID = InsertedID;
                }

                // Set ItemID to -1 to indicate failure
                else
                    ItemID = -1;
            }

            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                ItemID = -1;
            }

            finally
            {
                connection.Close();
            }

            return ItemID;
        }

        public static bool UpdateMenuItemInfo(int ItemID, string ItemName, byte ItemType, float Price, string Description, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE MenuItems
                            SET 
							ItemName = @ItemName,
							ItemType = @ItemType,
							Price = @Price,
							Description = @Description,
							ImagePath = @ImagePath
                            WHERE ItemID = @ItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@ItemName", ItemName);
            command.Parameters.AddWithValue("@ItemType", ItemType);
            command.Parameters.AddWithValue("@Price", Price);
            if (Description != "")
            {
                command.Parameters.AddWithValue("@Description", Description);
            }
            else
                command.Parameters.AddWithValue("@Description", DBNull.Value);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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

        public static bool DeleteMenuItem(int ItemID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE MenuItems
                              WHERE ItemID = @ItemID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemID", ItemID);

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

        public static DataTable GetAllMenuItems()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ItemID AS 'Item ID' , ItemName AS 'Item Name' ,
                            CASE 
	                            WHEN ItemType = 1 THEN 'Food'
	                            WHEN ItemType = 2 THEN 'Beverage'
	                            ELSE 'Not Specified'
                            END AS 'Item Type', Price , Description
                            FROM MenuItems;";

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
