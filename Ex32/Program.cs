using System.Text;

namespace Ex32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter their name.
            // Use an array to reverse the name and then store the result in a new string.
            // Display the reversed name on the console.  

            // ask the user for their name and store it in an array
            Console.WriteLine("Insert your name: ");
            string inputName = Console.ReadLine();


            // convert the array to a char array so it can be reversed
            char[] reversedName = inputName.ToCharArray();

            // reverse the array
            Array.Reverse(reversedName);

            // print the reversed name
            Console.WriteLine(reversedName);
        }
    }
}
