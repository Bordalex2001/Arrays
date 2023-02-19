using System;
using System.Text;

namespace Homework
{
    class Task6
    {
        static void Main()
        {
            Console.Write("Enter a text: ");
            StringBuilder sent = new StringBuilder(Console.ReadLine());

            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = lower.ToUpper();
            for (int i = 0; i < sent.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < lower.Length; j++)
                    {
                        if (sent[i] == lower[j])
                        {
                            sent[i] = upper[j];
                        }
                    }
                }
                else if (sent[i] == '.')
                {
                    for (int j = 0; j < lower.Length; j++)
                    {
                        if (sent[i + 2] == lower[j])
                        {
                            sent[i + 2] = upper[j];
                        }
                        else
                        {
                            sent[i] = '\0';
                        }
                    }
                }
            }
            Console.WriteLine("\nResult: " + sent);
        }
    }
}