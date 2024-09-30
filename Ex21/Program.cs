namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            // Display the count on the console.

            var count = 0;

            for (int i = 1; i < 100; i++)
            { 
                var num = i % 3;
                if (num == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numbers divisible by 3 between 1 and 100: {count}");
        }
    }
}
