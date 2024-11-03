using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx3
{
    internal class Program
    {
        /*
         * Ask the user for a number for the table
         * Write a loop to print X times table
         */
        static void Main(string[] args)
        {
            Console.Write("How many rows and columns should the table have? ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}
