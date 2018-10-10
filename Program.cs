using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restrictions

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            LFruits.ToList().ForEach(L => Console.WriteLine(L + " starts with L"));

            List<int> numbers = new List<int>()
            {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 ==0).OrderBy(n => n);

            fourSixMultiples.ToList().ForEach(multiple => Console.WriteLine(multiple + " is a multiple of 4 or 6"));

            // Ordering Operations
        }
    }
}
