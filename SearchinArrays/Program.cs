using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchinArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] validValues = {101, 102, 300, 301, 200, 600, 255, 400, 9 };
            Console.WriteLine("Enter your search query in numbers, please: ");

            int orderNumber = int.Parse(Console.ReadLine());
            Array.Sort(validValues);
            int answer = Array.BinarySearch(validValues, orderNumber);

            bool itemInStock = false;
            int position = 0;
            for (int i = 0; i < validValues.Length; i++)
            {
                if (orderNumber == validValues[i]) 
                {
                    itemInStock = true;
                    position = i;
                    break;
                }
            }
            if (itemInStock == true)
            {
                Console.WriteLine($"Item has been found in stock at position {position}!");
            }
            else
            {
                Console.WriteLine("Item does not exist in stock");
            }

        }
    }
}
