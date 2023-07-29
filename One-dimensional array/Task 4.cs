using System;

namespace Lab
{
    class Task4
    {
        static void Main()
        {
            Console.Write("Enter first array size (M): ");
            int M = int.Parse(Console.ReadLine());
            int[] arr1 = FillArray(M);
            Console.WriteLine();
            Console.Write("Enter second array size (N): ");
            int N = int.Parse(Console.ReadLine());
            int[] arr2 = FillArray(N);
            Console.WriteLine("\nThird array (without duplicates from first two arrays): ");
            int[] common_arr = MergeArrays(arr1, arr2);
            PrintCommonNum(common_arr);
        }
        static int[] FillArray(int size) //Заполнение и вывод первых двух массивов
        {
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(-50, 50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return arr;
        }
        static int[] MergeArrays(int[] arr1, int[] arr2) //Объединение массивов
        {
            int[] common_arr = new int[arr1.Length + arr2.Length];
            int index = 0;
            foreach (int num in arr1)
            {
                if (!IsDuplicate(common_arr, num, index))
                {
                    common_arr[index++] = num;
                }
            }
            foreach (int num in arr2)
            {
                if (!IsDuplicate(common_arr, num, index))
                {
                    common_arr[index++] = num;
                }
            }
            Array.Resize(ref common_arr, index);
            return common_arr;
        }
        static bool IsDuplicate(int[] arr, int num, int size) //Проверка числа на уникальность
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        static void PrintCommonNum(int[] arr) //Вывод общего третьего массива
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}