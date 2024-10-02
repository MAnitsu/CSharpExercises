namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that picks a random number between 1 and 10.
            // Give the user 4 chances to guess the number. If the user guesses the number,
            // display “You won"; otherwise, display “You lost".
            // (To make sure the program is behaving correctly,
            // you can display the secret number on the console first.)

            // creates a random number between 1 and 10
            var random = new Random();
            var luckyNum = random.Next(1, 10);

            // create a variable with the number of tries
            var chances = 4;

            while (chances >= 0)
            {
                // asks the user for a number
                Console.WriteLine("Guess a number between 1 and 10: ");
                int input = Convert.ToInt32(Console.ReadLine());

                // checks if the number inserted is between 1 and 10, if not the loop continues
                if (input < 0 || input > 10)
                {
                    Console.WriteLine("The number was not between 1 and 10!");
                    continue;
                }

                else
                {
                    // checks if the user guessed right
                    if (input == luckyNum)
                    {
                        Console.WriteLine($"You guessed it, the number was {input}!");
                        break;
                    }

                    else
                    {
                        // if there are no more tries left end the game
                        if (chances == 0)
                        {
                            Console.WriteLine("No more tries left, you lost!");
                            break;
                        }

                        // checks if there are tries left
                        else
                        {
                            Console.WriteLine($"Try again, you have {chances} chanches left");
                            chances--;
                            continue;
                        }
                    }
                }
            }
        }
    }
}
