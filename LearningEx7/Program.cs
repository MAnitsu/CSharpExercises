using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx7
{
    /*
     * Create two lists with integer data type, one for even numbers, one for odd
     * Loop from 0-20
        * if number is even, add to even list
        * if number is odd, add to odd list
     * Print even list
     * Print odd list */
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the two lists
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            // create a foor loop from 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) // checks if the number is even
                {
                    evenNumbers.Add(i); // adds the number to the even list
                }
                else // checks if number is odd
                {
                    oddNumbers.Add(i); // adds the number to the odd list
                }
            }

            Console.WriteLine("Even numbers: ");
            foreach (int number in evenNumbers) // prints every element from the even list
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            Console.WriteLine("Odd numbers: "); 
            foreach (int number in oddNumbers) // prints every element from the odd list
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
