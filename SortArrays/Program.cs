using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 15, 3, 53 };
            //Sort array elements
            Array.Sort(array1);

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            //Stop elements after the second element
            //int resize = 2;
            Array.Resize(ref array1, 2);
            Console.WriteLine("after resize");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
