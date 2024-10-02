namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5,
            // the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.  

            // ask the user for a number and convert it to int
            Console.WriteLine("Insert a number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            // display the factorial of the number inserted using the function
            Console.WriteLine($"{inputNum}! = {Factorial(inputNum)}");
        }

        // create a recursive function that returns the factorial of a number
        private static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            return num * Factorial(num - 1);
        }
    }
}
