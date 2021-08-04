using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace moreStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" | ");
                dict.Add(input[1], input[0]);
            }
            string[] letterRestrict = Console.ReadLine().Split(" - ");
            char startLetter = char.Parse(letterRestrict[0]);
            char endLetter = char.Parse(letterRestrict[1]);         

            foreach (var item in dict.Where(x => x.Key.First() > startLetter && x.Key.First() < endLetter))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
