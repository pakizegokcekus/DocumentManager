using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.BlueLoggingLibraryAdapter
{
    public class LogData
    {
        public string UserName { get; set; }
        public string LogMessage { get; set; }
        public string LogDateTime { get; set; }
        public LoggingLevel LogLevel { get; set; }
    }
    public enum LoggingLevel
    {
        Information, Warning, Error, Dangerous
    }
}
