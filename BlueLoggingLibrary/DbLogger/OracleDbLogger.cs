using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    class OracleDbLogger :ILoggerDb
    {
        internal OracleDbLogger()
        {

        }

        public string ConnectionSettings()
        {
            return "OracleDb bağlantı ayarları alındı";
        }
    }
}
