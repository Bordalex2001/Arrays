using System;

namespace Lab
{
    class Task9
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            Console.Write("Enter a word in the text: ");
            string word = Console.ReadLine();
            int repeats = CountRepeats(text, word);
            Console.Write($"Number of repeats: {repeats}");
            Console.WriteLine();
        }
        static int CountRepeats(string text, string word)
        {
            int repeats = 0;
            int index = 0;
            while ((index = text.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                repeats++;
                index += word.Length;
            }
            return repeats;
        }
    }
}