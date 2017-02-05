using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Utility
{
    public static class ParseHelper
    {
        /// <summary>
        /// cast string to an integer
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="defaultValue">the default value</param>
        /// <returns>value as integer</returns>
        public static int ToInt(string value, int defaultValue = -1)
        {
            int temp;
            return int.TryParse(value, out temp) ? temp : defaultValue;
        }

        /// <summary>
        /// cast string to boolean
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="defaultValue">default value</param>
        /// <returns>value as boolean</returns>
        public static bool ToBool(string value, bool defaultValue=false)
        {
            bool temp;
            return bool.TryParse(value, out temp) ? temp : defaultValue;
        }

        /// <summary>
        /// cast string to decimal
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="defaultValue">default</param>
        /// <returns>decimal value</returns>
        public static decimal ToDecimal(string value, decimal defaultValue=-1.000m)
        {
            decimal temp;
            return decimal.TryParse(value, out temp) ? temp : defaultValue;
        }

        /// <summary>
        /// cast string to double
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="defaultValue">default</param>
        /// <returns>double value</returns>
        public static double ToDouble(string value, double defaultValue=-1.00)
        {
            double temp;
            return double.TryParse(value, out temp) ? temp : defaultValue;
        }
    }
}
