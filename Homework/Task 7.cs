using System;
using System.Text;

namespace Homework
{
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            string[] forbidden = { "die", "fuck", "kill", "bitch", "shit" };
            int count = 0;
            foreach (string word in forbidden)
            {
                int index = 0;
                while (index != -1)
                {
                    index = text.IndexOf(word, index, StringComparison.OrdinalIgnoreCase);
                    if (index != -1)
                    {
                        count++;
                        index += word.Length;
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Found {count} forbidden words.");
                Console.WriteLine("Text with forbidden words will be replaced.");
                FilterText(text, forbidden);
            }
            else
            {
                Console.WriteLine("No forbidden words found, OK");
            }
        }
        static void FilterText(string text, string[] forbidden)
        {
            string filtered_text = text;
            foreach (string word in forbidden)
            {
                filtered_text = filtered_text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine("Filtered text:");
            Console.WriteLine(filtered_text);
        }
    }
}