using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FoudationConsoleApp.HelloWorld;
using FoudationConsoleApp.Number;
using FoudationConsoleApp.Occurance;
using FoudationConsoleApp.Pattern;
using FoudationConsoleApp.ReverseString;

namespace FoudationConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("WHAT YOU HAVE TO DO (ENTER THE NUMBER) \n 1. HELLO WORLD PROGRAM \n 2. NATURAL NUMBERS \n 3. PATTERN \n 4. REVERSE THE STRING \n 5. OCCURANCE \n ENTER THE INPUT:");
            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case 1:
                    Hello hello = new Hello();
                    hello.HelloWorldProgram();
                    break;                  


                case 2:
                    Numbers numbers = new Numbers();
                    numbers.NaturalNumbers();
                    break; 

                case 3:
                    StarPattern starPattern = new StarPattern();
                    starPattern.PatternStars();
                    break;

                case 4:
                    ReverseStringArray reverseStringArray = new ReverseStringArray();   
                    reverseStringArray.ReverseStringWitArray();
                    break;

                case 5:
                    StringOccurance stringOccurance = new StringOccurance();
                    stringOccurance.OccuranceString();
                    break;

                default:
                    Console.WriteLine("INVAILID-EXPRESSION");
                    break;

            }
            Console.ReadLine();
        }
    }
}
