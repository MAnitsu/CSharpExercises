using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx6
{
    internal class Program
    {
        /*
         * Ask user to enter password and store it
         * Ask user to enter password again and store it
         * Check if they both contain something
             * If so check if they are the same
                * If they are, print "Passwords match"
                * If they are not, print "Passwords do not match"
             * If they are empty, print "Please enter a password."
         */
        static void Main(string[] args)
        {
            while(true) { 
                Console.Write("Insert a password: ");
                string firstPassword = Console.ReadLine();

                Console.Write("Insert the password again: ");
                string secondPassword = Console.ReadLine();

                if (!string.IsNullOrEmpty(firstPassword) && !string.IsNullOrEmpty(secondPassword))
                {
                    if (firstPassword == secondPassword)
                    {
                        Console.WriteLine("Passwords match.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password.");
                    Console.WriteLine();
                }
            }
        }
    }
}
