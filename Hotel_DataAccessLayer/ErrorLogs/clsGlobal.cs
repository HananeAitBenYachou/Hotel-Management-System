using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer.ErrorLogs
{
    public static class clsGlobal
    {
        public static clsLogger DBLogger = new clsLogger(clsDBLogger.LogErrorToDatabase);
    }
}
