using System;
using System.Collections.Generic;
using System.Linq;

namespace FExPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            int totalTime = 0;
            
            while (true)
            {
                string[] input = Console.ReadLine().Split("; ");

                if(input[0] == "start of concert")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    List<string> members = input[2].Split(", ").ToList();
                    if (!bands.ContainsKey(input[1]))
                    {
                        bands.Add(input[1], new List<string>());
                    }

                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bands[input[1]].Contains(members[i]))
                        {
                            bands[input[1]].Add(members[i]);
                        }
                    }

                }

                if (input[0] == "Play")
                {
                    int currentTime = int.Parse(input[2]);
                    totalTime += currentTime;
                    if (!bandTime.ContainsKey(input[1]))
                    {
                        bandTime.Add(input[1], currentTime);
                    }
                    else
                    {
                        bandTime[input[1]] += currentTime;
                    }
                }

            }

            string finalLine = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime} "); 
            foreach (var item in bandTime.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var kvp in bands)
            {
                if (kvp.Key == finalLine)
                {
                    Console.WriteLine($"{kvp.Key}");

                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }

                }


            }
        }
    }
}