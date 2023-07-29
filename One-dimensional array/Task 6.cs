using System;

namespace Lab
{
    class Task6
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            char[] s = sentence.ToCharArray();
            int count_words = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (s[i] == ' ' || count_words == 0)
                {
                    count_words++;
                }
            }
            Console.WriteLine("Number of words: " + count_words);
        }
    }
}