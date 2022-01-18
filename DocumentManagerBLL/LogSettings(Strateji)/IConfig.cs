using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerBLL.LogSettings
{
    interface IConfig
    {
        string Save(string data);//todo Db or File
        string FormatLog(string data);//todo Html or Json
    }
}
