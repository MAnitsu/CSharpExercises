using System.ComponentModel;
using System;

namespace Ex31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            - If no one likes your post, it doesn't display anything.
            - If only one person likes your post, it displays: [Friend's Name] likes your post.
            - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern. */

            // creates an empty list to store the names
            var myNames = new List<string>();

            // Created a loop so the user will be asked for names until no more names are supplied
            while (true)
            {
                // Ask the user for a number and store it
                Console.WriteLine("Insert different names. Press ENTER after every name inserted: ");
                string inputNames = Console.ReadLine();

                // Checks if the inserted string is not empty, add it to the list
                if (!String.IsNullOrEmpty(inputNames))
                {
                    myNames.Add(inputNames);
                    continue;
                }

                // If the input is null break the loop and display the needed information
                else
                {
                    break;
                }
            }

            // Display the needed information based on the length of the list
            if (myNames.Count == 0)
            {
                Console.WriteLine("");
            }
            else if (myNames.Count == 1)
            {
                Console.WriteLine($"{myNames[0]} likes your post.");
            }
            else if (myNames.Count == 2)
            {
                Console.WriteLine($"{myNames[0]} and {myNames[1]} like your post.");
            }
            else
            {
                Console.WriteLine($"{myNames[0]} and {myNames[1]} and {myNames.Count - 2} others like your post.");
            }

        }
    }
}
