using System;
using System.Text;

namespace Homework
{
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            string s = Console.ReadLine();
            string[] hide = { "die", "fuck", "kill", "bitch", "shit"};
            double count = 0;
            for (int i = 0; i < hide.Length; i++)
            {
                count = (s.Length - s.Replace(hide[i], "").Length) / hide.Length + 1; 
                s = s.Replace(hide[i], "***");
            }
            Console.WriteLine($"\nResult: {s}\n\n{count} hidden words\n");
        }
    }
}