using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.Factorial
{
    public class FactorialNumbers
    {
        public void Factorial()
        {
            Console.Write("ENTER THE NUMBER: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int Result = 1;
            for (int i = Number; i >= 1; i--)
            {
                Result = Result * i;
            }
            Console.WriteLine(Result);
        
        
        }

    } 

}
