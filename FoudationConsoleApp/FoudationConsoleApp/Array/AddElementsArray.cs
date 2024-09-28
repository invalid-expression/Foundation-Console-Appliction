using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoudationConsoleApp.Array
{
    public class AddElementsArray
    {
        public void ElementsArray() 
        {
            int[] Elements = { 1, 2, 3, 4, 5 };

            int NewItem = 6;

            int[] NewArray = new int[Elements.Length + 1];


            for (int i = 0; i < Elements.Length; i++)
            {
                NewArray[i] = Elements[i];
            }

            NewArray[Elements.Length] = NewItem;

            foreach(int Items in NewArray)
            {
                Console.WriteLine(Items);
            }
        }
    }
}
