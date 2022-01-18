using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    class OracleDbLoggerFactory : IFactoryDb
    {
        internal OracleDbLoggerFactory()
        {

        }
        public ILoggerDb GetConnectionSettings()
        {
            return new OracleDbLogger();
        }
    }
}
