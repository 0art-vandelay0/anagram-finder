using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Anagram
    {
        private string mainWord;

        public Anagram(string mainWord)
        {
            this.mainWord = mainWord;
        }

        public List<string> FindAnagrams(string[] words)
        {
            List<string> anagrams = new List<string>();

            foreach (string word in words)
            {
                if (IsAnagram(mainWord, word))
                {
                    anagrams.Add(word);
                }
            }

            return anagrams;
        }

        private static bool IsAnagram(string mainWord, string word)
        {
            if (mainWord.Length != word.Length)
                return false;

            int[] charCount = new int[26];

            foreach (char c in mainWord)
                charCount[c - 'a']++;

            foreach (char c in word)
            {
                int index = c - 'a';
                charCount[index]--;
                if (charCount[index] < 0)
                    return false;
            }

            foreach (int count in charCount)
            {
                if (count != 0)
                    return false;
            }

            return true;
        }
    }
}
