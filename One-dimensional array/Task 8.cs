using System;

namespace Lab
{
    class Task8
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int count_vowels = CountVowels(sentence);
            Console.Write("Number of vowels: " + count_vowels);
            Console.WriteLine();
        }
        static bool IsVowel(char c)
        {
            char lower = char.ToLower(c);
            return lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u';
        }
        static int CountVowels(string sentence)
        {
            int vowels = 0;
            bool previousIsConsonant = false;
            foreach (char c in sentence)
            {
                if (IsVowel(c))
                { 
                    vowels++; 
                    previousIsConsonant = false;
                }
                else if (char.ToLower(c) == 'y')
                {
                    if (!previousIsConsonant)
                    {
                        vowels++;
                    }
                    previousIsConsonant = false;
                }
                else if (char.IsLetter(c))
                {
                    previousIsConsonant = true;
                }
                else
                {
                    previousIsConsonant = false;
                }
            }
            return vowels;
        }
    }
}