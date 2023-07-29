using System;

namespace Lab
{
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            char[] s = sentence.ToCharArray();
            for (int i = 0; i < sentence.Length - 1 - i; i++)
            {
                Array.Reverse(s);
            }
            Console.Write("Reversed sentence: ");
            Console.Write(s);
            Console.WriteLine();
        }
    }
}