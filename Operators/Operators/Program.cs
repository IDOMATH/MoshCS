using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            Console.WriteLine(a + b * c); // C# follows order of operations
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }
    }
}
