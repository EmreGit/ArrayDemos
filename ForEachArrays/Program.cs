using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region 
            //string[] names = { "Robben", "Timothy", "Mohammed", "Emre", "Mauro", "Wahab", "Khadija" };
            //This replaces a name with another
            //names[2] = "Kenan";

            //Foreach is read only
            //foreach (string name in names)
            //{
            //    names[2] = "Kenan";
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("********************************************");

            //foreach (string name in names)
            //{

            //    Console.WriteLine(name);
            //}


            //read - write // Length will know automatically how many strings there are in "names" in the array
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (i == 2)
            //    {
            //        names[i] = "Kenan";
            //    }
            //    Console.WriteLine(names[i]);

            #endregion

            string[] names = new string[4];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter a name, please...");
                names[i] = Console.ReadLine();
            }
            
        }
    }
}
