using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Dict_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playerAndCards = Console.ReadLine().Split();
            Dictionary<string, int> playersAndCards = new Dictionary<string, int>();
            while (playerAndCards[0] != "JOKER")
            {
                if (!playersAndCards.ContainsKey(playerAndCards[0]))
                {
                    int sum = 0;
                    for (int i = 1; i < playerAndCards.Length; i++)
                    {
                        int power = 0;
                        int type = 0;
                        if (Char.IsLetter(playerAndCards[i][0]))
                        {
                            if (playerAndCards[i][0] == 'J')
                            {
                                power = 11;
                            }
                            else if (playerAndCards[i][0] == 'Q')
                            {
                                power = 12;
                            }
                            else if (playerAndCards[i][0] == 'K')
                            {
                                power = 13;
                            }
                            else if (playerAndCards[i][0] == 'A')
                            {
                                power = 14;
                            }
                            
                        }
                        else
                        {
                            if (playerAndCards[i][0] == '1' && playerAndCards[i][1] == '0')
                            {
                                power = 10;
                            }
                            else
                            {
                                power = int.Parse(playerAndCards[i][0].ToString());
                            }
                        }
                        if (playerAndCards[i][1] == 'S')
                        {
                            type = 4;
                        }
                        else if (playerAndCards[i][1] == 'H')
                        {
                            type = 3;
                        }
                        else if (playerAndCards[i][1] == 'D')
                        {
                            type = 2;
                        }
                        else if (playerAndCards[i][1] == 'C')
                        {
                            type = 1;
                        }

                        sum += power * type;
                    }
                    playersAndCards.Add(playerAndCards[0], sum);
                }
                else
                {
                    
                    for (int i = 1; i < playerAndCards.Length; i++)
                    {
                        int power = 0;
                        int type = 0;
                        if (Char.IsLetter(playerAndCards[i][0]))
                        {
                            if (playerAndCards[i][0] == 'J')
                            {
                                power = 11;
                            }
                            else if (playerAndCards[i][0] == 'Q')
                            {
                                power = 12;
                            }
                            else if (playerAndCards[i][0] == 'K')
                            {
                                power = 13;
                            }
                            else if (playerAndCards[i][0] == 'A')
                            {
                                power = 14;
                            }                            
                        }
                        else
                        {
                            if (playerAndCards[i][0] == '1' && playerAndCards[i][1] == '0')
                            {
                                power = 10;
                            }
                            else
                            {
                                power = int.Parse(playerAndCards[i][0].ToString());
                            }
                        }
                        if (playerAndCards[i][1] == 'S')
                        {
                            type = 4;
                        }
                        else if (playerAndCards[i][1] == 'H')
                        {
                            type = 3;
                        }
                        else if (playerAndCards[i][1] == 'D')
                        {
                            type = 2;
                        }
                        else if (playerAndCards[i][1] == 'C')
                        {
                            type = 1;
                        }

                        playersAndCards[playerAndCards[0]] += type*power;
                    }
                    
                }
                playerAndCards = Console.ReadLine().Split();
            }

            foreach (var nameAndCard in playersAndCards)
            {
                Console.WriteLine($"{nameAndCard.Key} {nameAndCard.Value}");
            }
           
        }
    }
}
