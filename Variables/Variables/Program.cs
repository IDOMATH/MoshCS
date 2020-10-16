using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 17;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            string firstName = "Blane";
            bool isWorking = false;

            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(Pi);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        }
    }
}
