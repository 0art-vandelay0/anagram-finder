using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Anagram Checker!");

            Console.WriteLine("Enter the main word: ");
            string mainWord = Console.ReadLine();

            Console.WriteLine("Enter three other words separated by spaces: ");
            string[] otherWords = Console.ReadLine().Split(' ');

            Anagram anagram = new Anagram(mainWord);

            List<string> anagrams = anagram.FindAnagrams(otherWords);

            if (anagrams.Count > 0)
            {
                Console.WriteLine("Anagrams found:");
                foreach (string word in anagrams)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("No anagrams found.");
            }

            Console.ReadLine();
        }
    }
}
