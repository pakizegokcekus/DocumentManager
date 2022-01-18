using BlueLoggingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.BlueLoggingLibraryAdapter
{
    public class BlueLoggingLibraryAdapter : ILogger
    {
        private LogInformation logInformation;
        public BlueLoggingLibraryAdapter(LogInformation _logInformation)
        {
            logInformation = _logInformation;
        }

        public string Log(LogData data)
        {
            logInformation.UserName = data.UserName;
            logInformation.LogDateTime = data.LogDateTime;
            logInformation.LogMessage = data.LogMessage;
            //logInformation.LogLevel = data.LogLevel;
            return $"{data}loglama datası adapter tarafından düzenlenerek alındı";
        }
    }
}
