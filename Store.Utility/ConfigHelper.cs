using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Utility
{
    public static class ConfigHelper
    {
        //get the app settings from the configuration
        private static readonly NameValueCollection AppSettings = ConfigurationManager.AppSettings;

        /// <summary>
        /// pulls the default user Account 
        /// </summary>
        public static string DefaultAccountType => AppSettings["DefaultAccount"];

    }
}
