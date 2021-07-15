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
            if (!Regex.IsMatch(text, @"^[0-9]+$"))
            {
                throw new InputException(message);
            }
        }
    }
}
