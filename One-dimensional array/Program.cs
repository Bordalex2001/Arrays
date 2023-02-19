using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dimensional_array
{
    class Program
    {
        static void Main()
        {
            //0
            /*int[] arr = new int[10];
            Random r = new Random();
            Console.WriteLine("Исходный одномерный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 20);
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }*/

            //1
            int[] arr = new int[10];
            Random r = new Random();
            Console.WriteLine("Исходный одномерный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 20);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Чётные числа: " + i % 2 = 0);

            Console.WriteLine("Нечётные числа: ");
            Console.WriteLine("Уникальные числа: ");
        }
    }
}
