using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {            
            int countNums = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersInfo = new Dictionary<int, int>();

            for (int i = 0; i < countNums; i++)
            {
                int curNum = int.Parse(Console.ReadLine());
                if (!numbersInfo.ContainsKey(curNum))
                {
                    numbersInfo.Add(curNum, 1);
                }
                else
                {
                    numbersInfo[curNum] += 1;
                }               
            }

            foreach (var item in numbersInfo)
            {
                if(item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }

        }
    }
}