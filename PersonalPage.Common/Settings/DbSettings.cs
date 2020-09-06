using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Common.Settings
{
    public class DbSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string ConnectionString => $"mongodb://{Server}:{Port}";
    }
}
