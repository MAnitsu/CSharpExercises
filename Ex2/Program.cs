namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.  
            
            Console.WriteLine("Insert the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Insert the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} is greater than {1}", firstNumber, secondNumber);
            }
            else if (secondNumber > firstNumber) 
            {
                Console.WriteLine("{0} is greater than {1}", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }
    }
}
