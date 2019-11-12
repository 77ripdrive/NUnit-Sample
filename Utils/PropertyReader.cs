using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjectNunit.Utils
{
    class PropertyReader
    {
        public static string GetValue(string key)
        {
            ConfigurationManager.RefreshSection("appSettings");
            string value = System.Configuration.ConfigurationManager.AppSettings[key];
            
            return value;
        }
    }
}
