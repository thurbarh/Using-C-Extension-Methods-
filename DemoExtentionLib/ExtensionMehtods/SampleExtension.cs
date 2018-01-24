using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtentionLib.ExtensionMehtods
{
    public static class SampleExtension
    {
        public static bool IsValidInteger(this string input)
        {
            int i;
            return int.TryParse(input,out i);
        }
        public static bool IsValidDecimal(this string input)
        {
            decimal i;
            return decimal.TryParse(input, out i);
        }
        public static bool IsValidDouble(this string input)
        {
            double i;
            return double.TryParse(input, out i);
        }
        public static bool IsValidDate(this string input)
        {
            DateTime i;
            return DateTime.TryParse(input, out i);
        }
    }
}
