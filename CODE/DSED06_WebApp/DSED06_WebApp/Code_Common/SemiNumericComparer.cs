using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSED06_WebApp.Code_Common
{
    public class SemiNumericComparer : IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            if (IsNumeric(s1) && IsNumeric(s2))
            {
                if (Convert.ToInt32(s1) > Convert.ToInt32(s2)) return 1;
                if (Convert.ToInt32(s1) < Convert.ToInt32(s2)) return -1;
                if (Convert.ToInt32(s1) == Convert.ToInt32(s2)) return 0;
            }

            if (IsNumeric(s1) && !IsNumeric(s2))
                return -1;

            if (!IsNumeric(s1) && IsNumeric(s2))
                return 1;

            return string.Compare(s1, s2, true);
        }

        public static bool IsNumeric(object value)
        {
            try
            {
                //int i = Convert.ToInt32(value.ToString());
                int i;
                if (int.TryParse(value.ToString(), out i))
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}