using Hotel_BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.GlobalClasses
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool StoreUserCredentials(string Username , string Password)
        {
            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\UserData.txt";

                if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);

                    return true;
                }

                using(StreamWriter writer = new StreamWriter(FilePath))
                {
                    string UserCredentials = Username + "#//#" + Password;
                    writer.WriteLine(UserCredentials);

                    return true;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occured while trying to save the user credentials : {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredUserCredentials(ref string Username, ref string Password)
        {
            try
            {
                string CurrentDirectory = Directory.GetCurrentDirectory();
                string FilePath = CurrentDirectory + "\\UserData.txt";

                if(File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string Line;

                        while((Line = reader.ReadLine()) != null)
                        {
                            string[] UserCredentials = Line.Split(new string[] {"#//#"},StringSplitOptions.None);

                            Username = UserCredentials[0];
                            Password = UserCredentials[1];
                        }

                        return true;
                    }
                }

                else
                {
                    return false;
                }          
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while trying to save the user credentials : {ex.Message}");
                return false;
            }
        }
    
    }
}
