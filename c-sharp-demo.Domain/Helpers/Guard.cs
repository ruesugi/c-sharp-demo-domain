using c_sharp_demo.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace c_sharp_demo.Domain.Helpers
{
    public static class Guard
    {
        public static void IsNumber(string text, string message)
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(text, regex))
            {
                throw new InputException(message);
            }
        }

        public static void IsMailAddress(bool IsSending, string text, string message)
        {
            string regex = @"^[a-zA-Z0-9_.+-]+@([a-zA-Z0-9][a-zA-Z0-9-]*[a-zA-Z0-9]*\.)+[a-zA-Z]{2,}$";
            if (IsSending)
            {
                if (!Regex.IsMatch(text, regex))
                {
                    throw new InputException(message);
                }
            }
        }
    }
}
