using System;

namespace B10756051_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            double totle = meal_cost + tip_percent + tax_percent;
            Console.WriteLine(totle);
        }
    }
}
