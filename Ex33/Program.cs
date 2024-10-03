namespace Ex33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered,
            //display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers,
            //sort them and display the result on the console.

            // create an empty list to store the numbers from the user
            var myNums = new List<int>();

            // does a loop to ask for numbers
            while (true)
            {
                // checks if the list does not contain 5 elements so it can add to it until there are 5 elements
                if (myNums.Count != 5)
                {
                    // takes a number from the user and stores it into a string
                    Console.WriteLine("Insert a number: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    // checks if the inserted number is present in the list, if it is ask for another number without adding it to the list
                    if (myNums.Contains(input))
                    {
                        Console.WriteLine("The number is already in the list");
                        continue;
                    }
                    // if the number inserted is not in the list, add it to the list and continue the loop
                    else
                    {
                        myNums.Add(input);
                        continue;
                    }
                }

                // checks if the list contains 5 numbers
                else
                {
                    // sorts the numbers in the list
                    myNums.Sort();

                    // displays a string with the numbers from the list separated by comma and exist the loop
                    Console.WriteLine($"The inserted numbers were sorted: {string.Join(", ", myNums)}");
                    break;
                }
            }
        }
    }
}
