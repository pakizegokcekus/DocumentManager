using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    public class LoggerFactoryDb
    {
        LogInformation logInformation;
        public enum LogTypes
        {
            MsSqlDbLogger, OracleDbLogger, PdfFileLogger
        }
        private Dictionary<LogTypes, IFactoryDb> loggers = new Dictionary<LogTypes, IFactoryDb>();

        public LoggerFactoryDb(LogInformation log)
        {
            logInformation = log;
            loggers.Add(LogTypes.MsSqlDbLogger, new MsSqlDbLoggerFactory());
            loggers.Add(LogTypes.OracleDbLogger, new OracleDbLoggerFactory());
        }
        public IFactoryDb GetFactory(LogTypes logType)
        {
            return loggers[logType];
        }
    }
}
