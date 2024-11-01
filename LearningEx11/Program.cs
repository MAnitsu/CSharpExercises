using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx11
{
    internal class Program
    {
        /*
         * Create a int and try to convert any string to an int
         * Notice the error, write a try...catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Create a custom try parse function
         * Find the real function and copy return type/params
         * Read the tooltip it gives you, to give you ideas on what to do
         */
        static void Main(string[] args)
        {
            //bool looping = true;

            //while (looping) {
            //    try
            //    {
            //        Console.Write("Insert a number: ");
            //        int input = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine($"The number inserted is: {input}");
            //        looping = false;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please insert a number!");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Error: {e.Message}");
            //    }

            //    Console.WriteLine(looping ? "Not converted" : "Successfully converted!");

            Console.Write("Insert a number: ");
            if(ErrorCatcher(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"Successfully converted: {result}");
            }
            else
            {
                Console.WriteLine("Failed to convert!");
            }
   
        }

        static bool ErrorCatcher(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
