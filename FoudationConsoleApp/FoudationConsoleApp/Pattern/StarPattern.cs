using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.Pattern
{
    public class StarPattern
    {
        public void PatternStars()
        {
            int k = 1;

            Console.Write("\n");
            for (int i = 0; i <= 5; i++)
            {
                for(int j=0; j <= 5; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("");
                
            }

            Console.Write("\n");
            for (int i = 5; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}
