using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.Occurance
{
    public class StringOccurance
    {
        public void OccuranceString()
        {
            string str = "SIMPLIIE";
            string substring = "I";

            int count = (str.Length - str.Replace(substring, string.Empty).Length) / substring.Length;

            Console.WriteLine($"The substring '{substring}' occurs {count} times.");
        }
    }
}
