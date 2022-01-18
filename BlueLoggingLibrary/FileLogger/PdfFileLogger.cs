using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLoggingLibrary
{
    class PdfFileLogger : ILoggerFile
    {
        internal PdfFileLogger()
        {

        }
        public string Log()
        {
            return "PdfLogger çalıştı";
        }
    }
}
