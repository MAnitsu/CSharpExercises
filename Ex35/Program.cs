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

            // creates a loop so the user will be asked to retry if the list is invalid
            while (true)
            {
                // asks the user for the series of numbers
                Console.WriteLine("Enter a series of numbers separated by comma (ex \"5, 4, 9, 10\", no less than 5, and I will return the 3 smallest numbers: ");
                string input = Console.ReadLine();

                // checks if the list is empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Empty list, try again!");
                    continue;
                }

                // split the input and try to parse it to an array of integers and then to a list
                var numberList = input.Split(',') // Splits the input string by commas into an array of substrings.
                    .Select(n => { // Iterates through each substring (potential number).
                        int result;
                        if (int.TryParse(n.Trim(), out result)) // Tries to parse the trimmed substring into an integer.
                            return result; // If successful, return the parsed integer.
                        else
                            return (int?)null; // If not successful, return null (nullable integer).
                    })
                    .Where(n => n.HasValue) // Filters out null values (non-parsable entries).
                    .Select(n => n.Value) // Converts the nullable integers into normal integers.
                    .ToList(); // Collects the valid integers into a List<int>.

                // if the list contains less than 5 numbers prompts for a retry
                if (numberList.Count() < 5)
                {
                    Console.WriteLine("Invalid list, try again!");
                }

                else // checks if the list contains more than 5 numbers
                {
                    // get the 3 smallest numbers
                    var smallestNumbers = numberList.OrderBy(n => n).Take(3);

                    // display the 3 smallest numbers
                    Console.WriteLine($"The 3 smallest numbers are: {string.Join(", ", smallestNumbers)}");
                    break;
                }
            }
        }
    }
}
