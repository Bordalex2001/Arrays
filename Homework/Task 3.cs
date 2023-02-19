using System;
using System.Text;

namespace Homework
{
    class Task3
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            StringBuilder sentence = new StringBuilder(Console.ReadLine());
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string full = alphabet + alphabet.ToLower();
            int quantity = full.Length;
            int key = 3;
            string result = "";
            //string shift = "defghijklmnopqrstuvwxyzabc";
            for (int i = 0; i < sentence.Length; i++)
            {
                char cipher = sentence[i];
                int index = full.IndexOf(cipher);
                if (index < 0)
                {
                    result += cipher.ToString();
                }
                else
                {
                    int encrypt = (quantity + index + key) % quantity;
                    result += full[encrypt];
                }
            }
            Console.Write("\nEncrypted sentence: " + result);
            string original = "";
            for (int i = 0; i < result.Length; i++)
            {
                char cipher = result[i];
                int index = full.IndexOf(cipher);
                if (index < 0)
                {
                    original += cipher.ToString();
                }
                else
                {
                    int decrypt = (quantity + index - key) % quantity;
                    original += full[decrypt];
                }
            }
            Console.Write("\nDecrypted or original sentence: " + original);
            Console.WriteLine();
        }
    }
}
