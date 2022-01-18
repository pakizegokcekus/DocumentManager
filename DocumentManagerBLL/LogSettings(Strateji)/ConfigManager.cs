using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerBLL.LogSettings
{
    class ConfigManager
    {
        IConfig config;

        public ConfigManager(IConfig config)
        {
            this.config = config;
        }
        public string Save(string data)
        {
            return config.Save(data);
        }
        public string FormatLog(string data)
        {
            return config.FormatLog(data);
        }
    }
}
