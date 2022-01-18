using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    class MsSqlDbLoggerFactory:IFactoryDb
    {
        internal MsSqlDbLoggerFactory()
        {

        }

        public ILoggerDb GetConnectionSettings()
        {
            return new MsSqlDbLogger();
        }
    }
}
