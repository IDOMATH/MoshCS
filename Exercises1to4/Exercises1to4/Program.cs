using System;

namespace Exercises1to4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Input a number between 1 and 10.");
            int input = Convert.ToInt32(Console.ReadLine());
            string validity = (input <= 10 && input >= 1) ? "Valid" : "Invalid";
            Console.WriteLine(validity);

            // Exercise 2
            Console.WriteLine("input 2 numbers: ");
            int in1 = Convert.ToInt32(Console.ReadLine());
            int in2 = Convert.ToInt32(Console.ReadLine());

            if (in1 > in2)
                Console.WriteLine(in1);
            else
                Console.WriteLine(in2);

            //Exercise 3
            Console.WriteLine("enter width followed by height");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
                Console.WriteLine("Landscape");
            else if (width < height)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Square");

            //Exercise 4
            Console.WriteLine("Input speed limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            int points = (speed - limit) / 5;

            if (points > 12)
                Console.WriteLine("License suspended");
            else if (points <= 0)
                Console.WriteLine("ok");
            else
                Console.WriteLine(points);
        }
    }
}
