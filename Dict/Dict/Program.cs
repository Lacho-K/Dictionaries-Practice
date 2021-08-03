using System;
using System.Collections.Generic;
using System.Linq;
namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsInfo = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < studentsCount; i++)
            {
                string[] currStudent = Console.ReadLine().Split();
                if (!studentsInfo.ContainsKey(currStudent[0]))
                {
                    studentsInfo.Add(currStudent[0], new List<decimal> {decimal.Parse(currStudent[1])});
                }
                else
                {
                    studentsInfo[currStudent[0]].Add(decimal.Parse(currStudent[1]));
                }
            }
            foreach (KeyValuePair<string,List<decimal>> student in studentsInfo)
            {
                Console.WriteLine($"{student.Key} -> {String.Join(' ', student.Value):F2} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
