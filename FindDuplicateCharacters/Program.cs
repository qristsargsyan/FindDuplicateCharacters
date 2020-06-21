using System;
using System.Collections.Generic;

namespace FindDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            FindDoublicateCharactersCount.Find();
        }
    }
}
    static class FindDoublicateCharactersCount
    {
        public static void Find()
        {
            string line = Console.ReadLine();
            char[] alonechar = line.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var ch in alonechar)
            {
                if (dictionary.ContainsKey(ch))
                {
                    dictionary[ch] = dictionary[ch] + 1;
                }
                else
                {
                    dictionary.Add(ch, 1);
                }
            }
            var keys = new HashSet<char>(dictionary.Keys);
            foreach (var ch in keys)
            {
                if (dictionary[ch] >= 1)
                {
                    Console.WriteLine($"Character {ch} repeating {dictionary[ch]} times");
                }
            }
        }
    }
  

