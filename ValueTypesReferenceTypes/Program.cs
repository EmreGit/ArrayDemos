using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            //int a = 10;
            //int b = a;
            //b = 55;

            //Console.WriteLine(b);

            //int[] array1 = { 5, 15, 3, 53 };
            //foreach (int item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*******************");

            //int[] array2 = array1;

            //array2[2] = 9999;


            //foreach (int item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            /*Making a clone with array cloning, whereby you can copy 
            the exact array but still modify a value somewhere to output a 
            different one in the next array*/

            int[] array1 = { 5, 15, 3, 53 };

            int[] array2 = (int[])array1.Clone();

            array2[2] = 9999;
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
