using System;
using System.Dynamic;
using System.Linq;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);

            // Exercise 2
            int sum = 0;
            Console.WriteLine("enter numbers followed by \"ok\" to sum them.");
            string input = Console.ReadLine();

            while (input != "ok")
            {
                sum += Convert.ToInt32(input);
                input = Console.ReadLine();
                continue;
            }
            Console.WriteLine(sum);

            // Exercise 3
            Console.WriteLine("Enter number to be factorial'd");
            int fact = Convert.ToInt32(Console.ReadLine());
            int total = 1;

            for (int i = fact; i >= 1; i--)
            {
                total *= i;
            }
            Console.WriteLine("total: " + total);

            // Exercise 4
            Random random = new Random();
            int magicNumber = random.Next(1, 10);
            int numGuesses = 0;
            Console.WriteLine("Pick a number between 1 and 10.");
            while (numGuesses < 4)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == magicNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                numGuesses++;
                Console.WriteLine("Keep guessing");
            }
            if (numGuesses == 4)
                Console.WriteLine("Number was: {0}.  You lose", magicNumber);

            // Exercise 5
            Console.WriteLine("Enter numbers separated by a comma.");
            string numbers = Console.ReadLine();
            int[] numsArr = numbers.Split(',').Select(int.Parse).ToArray();

            int max = numsArr[0];

            foreach (int num in numsArr)
            {
                if (num > max)
                    max = num;
            }
            Console.WriteLine("Max is: " + max);
        }
    }
}
