using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (!charCount.ContainsKey(input[i][j]))
                    {
                        charCount.Add(input[i][j], 1);
                    }
                    else
                    {
                        charCount[input[i][j]] += 1;
                    }
                }
            }

            foreach (var item in charCount)
            {
                Console.WriteLine(item.Key + "->" + item.Value);
            }
        }
    }
}
