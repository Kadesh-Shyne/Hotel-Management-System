using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_Application.Contracts;

namespace Hospital_Management_Logging
{
    public class LoggerManager: ILoggerManager
    {
        private static LoggerManager? logger; 

        public void LogDebug(string message)
        {
            logger?.LogDebug(message);
        }

        public void LogError(string message)
        {
           logger?.LogError(message);
        }

        public void LogInfo(string message)
        {
           logger?.LogInfo(message);
        }

        public void LogWarn(string message)
        {
          logger?.LogWarn(message);
        }
    }
}
