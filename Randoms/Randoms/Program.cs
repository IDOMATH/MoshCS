using System;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next());
        }
    }
}
