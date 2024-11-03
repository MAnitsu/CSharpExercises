using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEx9
{
    internal class Program
    {
        /* 
         * Ask the user for width and height, store them
         * create a function to calculate the area of a triangle
         * function should calculate area using: (width * height) / 2
         * call in main and print out the area of the triangle
         */
        static void Main(string[] args)
        {
            Console.Write("Insert the width: ");
            double inputWidth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert the height: ");
            double inputHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area is {TriangleArea(inputWidth, inputHeight)}");

        }

        static double TriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
