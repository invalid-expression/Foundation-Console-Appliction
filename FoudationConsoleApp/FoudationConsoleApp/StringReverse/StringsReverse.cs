using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.StringReverse
{
    public class StringsReverse
    {
        public void ReverseString()
        {
            string ReverseString = string.Empty;
            string StaraightString = "Rohit";

            for (int i = StaraightString.Length - 1; i>=0; i--)
            {
                ReverseString = ReverseString + StaraightString[i];
            }
            Console.WriteLine($"YOUR PRE DEFINED REVERSE STRING IS: {ReverseString}");
        }
    }
}
