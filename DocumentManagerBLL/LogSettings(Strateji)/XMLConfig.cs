using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerBLL.LogSettings
{
    class XMLConfig : IConfig
    {
        public string FormatLog(string data)
        {
            return $"{data} verisi ?? formatında loglandı.";
        }

        public string Save(string data)
        {
            return $"{data} verisi ?? kaynağına kaydedildi";
        }
    }
}
