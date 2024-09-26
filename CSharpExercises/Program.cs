namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid".  

            while (true)
            {
                Console.WriteLine("Insert a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 && number <= 10)
                {
                    Console.WriteLine("Valid");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
            }
        }
    }
}
