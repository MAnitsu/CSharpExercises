namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example,
            //if the user enters “5, 3, 8, 1, 4", the program should display 8.


            // asks the user for the series of numbers
            Console.WriteLine("Enter a series of numbers separated by comma (ex \"5, 4, 9, 10\" and I will return the maximum of those numbers: ");
            string input = Console.ReadLine();

            // creates an array of strings that are split by commas
            string[] values = input.Split(',');

            // converts the array of strings to an array of ints so they can be compared
            int[] myInts = values.Select(int.Parse).ToArray();

            // displays the maximum value
            Console.WriteLine($"The maximum value is {myInts.Max()}");
        }
    }
}
