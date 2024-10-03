namespace Ex35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            // If the list is empty or includes less than 5 numbers,
            // display "Invalid List" and ask the user to re-try;
            // otherwise, display the 3 smallest numbers in the list.

            // create a list where the input numbers will be stored
            var myNums = new List<int>();

            // create an empty list for the 3 smallest values to be stored in
            var smallestNums = new List<int>();

            // creates a loop so the user will be asked to retry if the list is invalid
            while (true)
            {
                // asks the user for the series of numbers
                Console.WriteLine("Enter a series of numbers separated by comma (ex \"5, 4, 9, 10\", no less than 5, and I will return the 3 smallest numbers: ");
                string input = Console.ReadLine();

                // checks if the list is empty
                if (!String.IsNullOrEmpty(input))
                {
                    // creates an array of strings that are split by commas
                    string[] values = input.Split(',');

                    // convert the array to int
                    int[] myInts = Array.ConvertAll(values,int.Parse);

                    // add the elements from the split array to the list of numbers
                    myNums.AddRange(myInts);

                    // checks if the array contains more than 5 numbers
                    if (myNums.Count() >= 5)
                    {
                        // create a for loop that will take the 3 smallest numbers and insert them into the new list
                        for (int i = 0; i < 3; i++)
                        {
                            int min = myNums.Min();

                            // add the minimum value to the new list
                            smallestNums.Add(min);

                            // remove the minimum found from the original list so it will not be taken as a min again
                            myNums.Remove(min);

                        }

                        // display the 3 smallest numbers
                        Console.WriteLine($"The 3 smallest numbers are: {string.Join(", ", smallestNums)}");
                        break;
                    }

                    // if the array contains less than 5 numbers prompts for a retry
                    else
                    {
                        Console.WriteLine("Invalid list, try again!");
                        continue;
                    }
                }

                // if the lists is empty prompt to try again
                else
                {
                    Console.WriteLine("Invalid list, try again!");
                    continue;
                }
            }
        }
    }
}
