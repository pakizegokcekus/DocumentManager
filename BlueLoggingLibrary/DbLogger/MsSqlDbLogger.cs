using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    class MsSqlDbLogger :ILoggerDb
    {
        internal MsSqlDbLogger()
        {

        }

        public string ConnectionSettings()
        {
            return "MsSqlDb bağlantı ayarları alındı";
        }
    }
}
