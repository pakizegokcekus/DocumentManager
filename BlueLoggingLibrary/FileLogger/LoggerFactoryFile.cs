using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    public class LoggerFactoryFile
    {
        LogInformation logInformation;
        public enum LogTypes
        {
            PdfFileLogger
        }
        private Dictionary<LogTypes, IFactoryFile> loggers = new Dictionary<LogTypes, IFactoryFile>();
    
        public LoggerFactoryFile(LogInformation log)
        {
            logInformation = log;
            loggers.Add(LogTypes.PdfFileLogger, new PdfFileLoggerFactory());
        }
        public IFactoryFile GetFactory(LogTypes logType)
        {
            return loggers[logType];
        }
    }
}
