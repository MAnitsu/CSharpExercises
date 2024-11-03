using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx10
{
    internal class Program
    {
        /* 
         * Create initialise int array of numbers
         * create a function SumOfNumbers with int return type
         * int array param
         * function should return the total of all the numbers
         * call in main and output the total
         * extra: check array length
            * return -1 if array empty
            * check return in main and output message
         */
        static void Main(string[] args)
        {
            int[] myNums = new int[]{1, 3, 45};
            int result = SumOfNumbers(myNums);
            if (result == -1)
            {
                Console.WriteLine("Cannot add up an empty array");
            }
            else
            {
                Console.WriteLine($"Total: {result}");
            }
        }

        static int SumOfNumbers(int[] nums)
        {
            int total = 0;
            if (nums.Length.Equals(0))
                return -1; 
  
            else
            {
                foreach (int num in nums)
                {
                    total += num;
                }
                return total;
            }
            
        }
    }
}
