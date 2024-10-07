using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx2
{
    internal class Program
    {
        /*
         * Create and initialise two ints
         * Make a variable to work out the remainder
         * Output remainder to the screen
         * Change the first int variable to another number
             * and recalculate the remainder
             * output new remainder to the screen
         */
        static void Main(string[] args)
        {
            int a = 9;
            int b = 2;
            Console.WriteLine(a % b);

            a = 20;
            Console.WriteLine(a % b);
        }
    }
}
