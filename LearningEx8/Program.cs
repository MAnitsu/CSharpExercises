using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx8
{
    /*
     * Define and initialize two integers (num, length)
     * (7, 5) -> [7, 14, 21, 28, 35]
     * Create int array with size length
     * loop through and insert the (loop counter x num) into the array
     * print the final array */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = (i + 1) * num;
            }

            foreach (int i in result)
            {
                Console.WriteLine($"{num} * {Array.IndexOf(result, i) + 1} = {i}");
            }
        }
    }
}
