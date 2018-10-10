using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restrictions ///////////////////

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            LFruits.ToList().ForEach(L => Console.WriteLine(L + " starts with L"));

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 ==0).OrderBy(n => n);

            fourSixMultiples.ToList().ForEach(multiple => Console.WriteLine(multiple + " is a multiple of 4 or 6"));

            // Ordering Operations ///////////////////

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = from name in names
            orderby name descending
            select name;

            descend.ToList().ForEach(letter => Console.WriteLine(letter));

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> ascend = from number in numbers2
            orderby number ascending
            select number;

            ascend.ToList().ForEach(number => Console.WriteLine(number));

            // Aggregate Operations //////////////////

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
        }
    }
}
