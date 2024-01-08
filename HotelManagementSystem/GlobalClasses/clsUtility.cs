using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public static class clsUtility
    {
        public static string GenerateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if(!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error occured while creating folder : "+ ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGuid(string SourceFile)
        {          
            FileInfo fileInfo = new FileInfo(SourceFile);

            // replace the file name but keep the extension type
            return GenerateNewGuid() + fileInfo.Extension;

        }

        public static bool CopyImageToProjectImagesFolder(string DestinationFolder , ref string SourceFile)
        {
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWithGuid(SourceFile); 

            try
            {
                File.Copy(SourceFile, DestinationFile);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            SourceFile = DestinationFile;
            return true;
        }

    }
}
