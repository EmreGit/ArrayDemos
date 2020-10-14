using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Innit array old way
            ////int i = 15;
            //int[] data = new int[3];
            //data[0] = 123;
            //data[1] = 5;
            //data[2] = 600;

            //Console.WriteLine(data[2]);
            ////Console.WriteLine($"The value of index: "+ data[2]);
            ////Console.WriteLine($"The value of index {data[3 - 1]}" + data[2]);

            #endregion

            //Best way to use arrays 
            int[] ages = { 12, 5, 60, 100, 26, 75 };
            //Console.WriteLine(ages[2]);

            string[] names = { "Jan", "Piet", "Tom", "Pim", "Joe", "Ian" };
            Console.WriteLine($"{names[1]} is {ages[1+2]} years old");
        }
    }
}
