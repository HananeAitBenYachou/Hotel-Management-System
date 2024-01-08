using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DataAccessLayer.ErrorLogs
{
    public class clsLogger
    {
        //Define a delegate for log actions
        public delegate void LogAction(string ErrorMessage , string ExceptionType);

        //The log action that will be invoked
        private LogAction _LogAction;

        public clsLogger(LogAction LogAction)
        {
            _LogAction = LogAction;
        }

        public void LogError(string ErrorMessage, string ExceptionType)
        {
            _LogAction(ErrorMessage, ExceptionType);
        }
    }
}
