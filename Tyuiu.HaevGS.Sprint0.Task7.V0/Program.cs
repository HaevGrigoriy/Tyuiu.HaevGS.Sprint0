using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HaevGS.Sprint0.Task7.V0.Lib;

namespace Tyuiu.HaevGS.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";


            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine();
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i]);
                }

            }
            else
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
