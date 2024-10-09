using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx4
{
    internal class Program
    {
        /*
         * Create a for loop from 1 to X (15)
         * if the number is divizible by 3 and 5 = FizzBuzz
         * if by 3 = Fizz
         * if by 5 = Buzz
         * else = number
         */
        static void Main(string[] args)
        {
            Console.Write("Insert a number from 1 to 15: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= input; i++)
            {
                threeDiv = i % 3 == 0; // creating these 2 bools makes the program more memory efficient
                fiveDiv = i % 5 == 0;  // because it will only calculate the values twice instead of calculating
                                       // them for every value in the loop, the program will run faster and more memory efficient

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
