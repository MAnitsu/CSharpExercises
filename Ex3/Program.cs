namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.

            Console.WriteLine("Insert the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("The image is portrait");
            }
            else
            {
                Console.WriteLine("Height and width are equal");
            }
        }
    }
}
