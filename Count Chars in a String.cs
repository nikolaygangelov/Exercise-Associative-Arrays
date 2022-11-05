using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (occurrences.ContainsKey(ch))
                    {
                        occurrences[ch] = 0;
                    }
                    occurrences[ch]++;
                }
            }

            foreach (var kvp in occurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
