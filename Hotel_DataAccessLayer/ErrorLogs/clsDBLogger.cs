using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer.ErrorLogs
{
    public static class clsDBLogger
    {
        private static bool _LogNewError(string ErrorMessage , string ExceptionType)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO ErrorLogs (ErrorMessage,ExceptionType,OccurredDate)
                            VALUES (@ErrorMessage,@ExceptionType,@OccurredDate);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ErrorMessage", ErrorMessage);
            command.Parameters.AddWithValue("@ExceptionType", ExceptionType);
            command.Parameters.AddWithValue("@OccurredDate", DateTime.Now);


            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static void LogErrorToDatabase(string ErrorMessage,string ExceptionType)
        {
            _LogNewError(ErrorMessage, ExceptionType); 
        }

    }
}
