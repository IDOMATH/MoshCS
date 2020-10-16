using System;

namespace ReferenceVsValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b++;

            Console.WriteLine("b: {0} and a: {1}", b, a);

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = arr1;

            arr2[0] = 0;
            Console.WriteLine("arr1[0]: {0} arr2[0]: {1}", arr1[0], arr2[0]);
        }
    }
}
