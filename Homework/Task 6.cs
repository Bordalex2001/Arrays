using System;
using System.Text;

namespace Homework
{
    class Task6
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            text.Append(input[0].ToString().ToUpper());
            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && char.IsWhiteSpace(input[i - 1]) && ".!?".IndexOf(input[i - 2]) != -1)
                {
                    text.Append(input[i].ToString().ToUpper());
                }
                else
                {
                    text.Append(input[i]);
                }
            }
            Console.WriteLine("\nResult: " + text);
        }
    }
}