using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.ReverseString
{
    public class ReverseStringArray
    {
        public void ReverseStringWitArray()
        {
            string Reverse = string.Empty;
            Console.Write("ENTER YOUR NAME: ");
            string input = Convert.ToString(Console.ReadLine());

            for (int i = input.Length-1; i >= 0 ; i--)
            {
  
                Reverse += input[i];
            }
            Console.WriteLine($"YOUR REVERSE STRING IS: {Reverse}");
        }
    }
}
