using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    public interface IFactoryDb
    {
        ILoggerDb GetConnectionSettings();
    }
}
