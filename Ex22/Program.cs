namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console. 

            // Created an empty list to store my input numbers
            var myNums = new List<int>();

            // Created a loop so the user will be asked for numbers until writing "ok"
            while (true)
            {
                // Ask the user for a number and store it
                Console.WriteLine("Insert a number: ");
                string inputNum = Console.ReadLine();

                // Checks if the user inserts "ok" to be able to get out of the while loop and do the sum
                if (inputNum.Equals("ok"))
                {
                    break;
                }

                // If the input is not "ok" the input will be converted to int and added to the list (I will not check for errors as this is not the scope of this exercise)
                else
                {
                    int newInputNum = Convert.ToInt32(inputNum);
                    myNums.Add(newInputNum);
                }
            }

            // Display the sum
            Console.WriteLine($"The sum of the numbers is: {myNums.Sum()}");

        }
    }
}
