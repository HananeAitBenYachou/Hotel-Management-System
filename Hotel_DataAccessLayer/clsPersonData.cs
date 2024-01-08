using Hotel_DataAccessLayer.ErrorLogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID
            (int PersonID , ref string FirstName , ref string LastName , ref string NationalNo ,
            ref char Gender, ref DateTime BirthDate , ref string Address , ref string Phone ,
            ref string Email , ref int NationalityCountryID , ref string PersonalImagePath)

        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    Gender = ((string)reader["Gender"])[0];
                    BirthDate = (DateTime)reader["BirthDate"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    // Handle null value for PersonalImagePath since it allows null in the database
                    if (reader["PersonalImagePath"] == System.DBNull.Value)                
                        PersonalImagePath = "";
                    
                    else
                        PersonalImagePath = (string)reader["PersonalImagePath"];

                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetPersonInfoByNationalNo
            (string NationalNo , ref int PersonID, ref string FirstName, ref string LastName,
            ref char Gender, ref DateTime BirthDate, ref string Address, ref string Phone,
            ref string Email, ref int NationalityCountryID, ref string PersonalImagePath)

        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo",NationalNo);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found successfully !
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    LastName = (string)reader["LastName"];
                    Gender = ((string)reader["Gender"])[0];
                    BirthDate = (DateTime)reader["BirthDate"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    // Handle null value for PersonalImagePath since it allows null in the database
                    if (reader["PersonalImagePath"] == System.DBNull.Value)
                        PersonalImagePath = "";

                    else
                        PersonalImagePath = (string)reader["PersonalImagePath"];
                }

                else
                {
                    // The record wasn't found !
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT IsFound = 1 FROM People WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                // Check if the reader object is null to determine if the record was found
                IsFound = (reader != null);

            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT IsFound = 1 FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            object reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteScalar();

                // Check if the reader object is null to determine if the record was found
                IsFound = (reader != null);

            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewPerson
            (string FirstName, string LastName, string NationalNo,
             char Gender, DateTime BirthDate, string Address, string Phone,
             string Email, int NationalityCountryID, string PersonalImagePath)
        {
            //this function will return the newly added Person's ID if it was inserted successfully
            //otherwise it will return -1 

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO People (FirstName,LastName,NationalNo,Gender,
                            BirthDate,Address,Phone,Email,NationalityCountryID,PersonalImagePath)
                            VALUES (@FirstName,@LastName,@NationalNo,@Gender,
                            @BirthDate,@Address,@Phone,@Email,@NationalityCountryID,@PersonalImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if(PersonalImagePath != "" && PersonalImagePath != null)
                command.Parameters.AddWithValue("@PersonalImagePath", PersonalImagePath);
            else
                command.Parameters.AddWithValue("@PersonalImagePath", System.DBNull.Value);

            object InsertedRowID = 0;

            try
            {
                connection.Open();
                InsertedRowID = command.ExecuteScalar();

                //Check if the new PersonID was successfully inserted
                if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                    PersonID = InsertedID;

                // Set PersonID to -1 to indicate failure
                else
                    PersonID = -1;

            }
            catch (Exception ex)
            {
                PersonID = -1;
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson
            (int PersonID ,string FirstName, string LastName, string NationalNo,
             char Gender, DateTime BirthDate, string Address, string Phone,
             string Email, int NationalityCountryID, string PersonalImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE People 
                            SET FirstName = @FirstName,
                            LastName = @LastName,
                            NationalNo = @NationalNo,
                            Gender = @Gender,
                            BirthDate = @BirthDate,
                            Phone = @Phone,
                            Address = @Address,
                            Email = @Email,
                            NationalityCountryID = @NationalityCountryID,
                            PersonalImagePath = @PersonalImagePath
                            WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (PersonalImagePath != "" && PersonalImagePath != null)
                command.Parameters.AddWithValue("@PersonalImagePath", PersonalImagePath);
            else
                command.Parameters.AddWithValue("@PersonalImagePath", System.DBNull.Value);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsGlobal.DBLogger.LogError(ex.Message, ex.GetType().FullName);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE People WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllPeople()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM People;";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = null;

            DataTable DataTable = new DataTable();

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable.Load(reader);
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

            return DataTable;
        }

    }
}
