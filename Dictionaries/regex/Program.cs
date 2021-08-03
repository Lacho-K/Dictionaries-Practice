using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string[], string> storage = new Dictionary<string[], string>();
            Dictionary<string, string> resultDict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] files = Console.ReadLine().Split(new[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string fileSize = files.Last();
                files = files.Take(files.Length - 1).ToArray();
                storage.Add(files, fileSize);
            }

            string[] target = Console.ReadLine().Split();
            string extensionTarget = target[0].Trim();
            string placeTarget = target[target.Length - 1].Trim();
            bool printNo = true;
            foreach (var item in storage)
            {
                if (item.Key.Contains(placeTarget))
                {
                    if (item.Key[item.Key.Length - 1].Contains(extensionTarget))
                    {
                        if (!resultDict.ContainsKey(item.Key[item.Key.Length - 1]))
                        {
                            resultDict.Add(item.Key[item.Key.Length - 1], item.Value);
                        }
                        else
                        {
                            resultDict[item.Key[item.Key.Length - 1]] = item.Value;
                        }
                        printNo = false;
                    }
                }
            }
            foreach (var item in resultDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value} KB");
            }
            if (printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}