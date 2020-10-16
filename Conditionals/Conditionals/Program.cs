using System;

namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("it's afternoon");
            //}
            //else Console.WriteLine("it's evening");
            // Will output morning.

            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            // line below and block above do the same thing
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("it's autumn and a beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("summer is the shit");
                    break;
                default:
                    Console.WriteLine("Don't know that season");
                    break;
            }
        }
    }
}
