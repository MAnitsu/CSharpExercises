namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Your job is to write a program for a speed camera.
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit.
             * Once set, the program asks for the speed of a car.
             * If the user enters a value less than the speed limit, program should display Ok on the console.
             * If the value is above the speed limit, the program should calculate the number of demerit points.
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             * If the number of demerit points is above 12, the program should display License Suspended. */

            Console.WriteLine("Insert the speed limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the speed of the car: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (limit >= carSpeed)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demerit = (carSpeed - limit) / 5;

                if (demerit <= 12)
                {
                    Console.WriteLine("Demerit points: {0}", demerit);
                }

                else
                {
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}
