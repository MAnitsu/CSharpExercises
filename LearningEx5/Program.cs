using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearningEx5
{
    internal class Program
    {
        /*
         * Ask user to input a message
         * Print in order
         * Print in reverse
         */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write a message: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {

                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.Write(input[i]);
                    }

                    Console.WriteLine();
                    Console.Write("The reversed message is: ");

                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        Console.Write(input[i]);
                    }

                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid message, try again!");
                }
            }
        }
    }
}
