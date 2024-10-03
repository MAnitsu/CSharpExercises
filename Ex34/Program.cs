namespace Ex34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates.
            // Display the unique numbers that the user has entered.

            // create a list to store the numbers
            var myNums = new List<string>();

            // create a loop to continuously ask for input
            while (true)
            {
                // asks for input and converts it to lower case so it does not matter how the user writes "quit"
                Console.WriteLine("Insert a number: ");
                string input = Console.ReadLine().ToLower();

                // if the user did not input "quit" do:
                if (!input.Contains("quit"))
                {
                    // add the input number to the list and continue the loop
                    myNums.Add(input);
                    continue;
                }
                
                // if the user entered "quit":
                else
                {
                    // converts the list of strings to a list of integers
                    myNums.Select(int.Parse).ToList();

                    // finds the unique numbers in the list and assign them to a variable
                    var distinctNums = myNums.Distinct();

                    // displays the unique numbers in a string and exit the loop
                    Console.WriteLine($"The unique numbers you entered are: {string.Join(", ", distinctNums)}");
                    break;
                }
            }
        }
    }
}
