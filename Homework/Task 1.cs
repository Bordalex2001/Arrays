using System;

namespace Homework
{
    class Task1
    {
        static void Main()
        {
            int[] A = new int[5];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Index {i}: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            int min_A = A[0];
            int max_A = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (min_A > A[i])
                {
                    min_A = A[i];
                }
                if (max_A < A[i])
                {
                    max_A = A[i];
                }
            }
            int sum_A = 0;
            int prod_A = 1;
            int even = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum_A += A[i];
                prod_A *= A[i];
                if(A[i] % 2 == 0)
                {
                    even += A[i];
                }
            }
            Console.Write("\n");
            foreach(int a in A)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("\nMinimum element = {0}", min_A);
            Console.WriteLine("Maximum element = {0}", max_A);
            Console.WriteLine("Sum: {0}", sum_A);
            Console.WriteLine("Product: {0}", prod_A);
            Console.WriteLine();
            Console.WriteLine();
            
            int[,] B = new int[3, 4];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = r.Next(-28, 28);
                    Console.Write("{0,5}", B[i, j]);
                }
                Console.WriteLine();
            }
            int min_B = B[0, 0];
            int max_B = B[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (min_B > B[i, j])
                    {
                        min_B = B[i, j];
                    }
                    if (max_B < B[i, j])
                    {
                        max_B = B[i, j];
                    }
                }
            }
            int sum_B = 0;
            int prod_B = 1;
            int uneven = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    sum_B += B[i, j];
                    prod_B *= B[i, j];
                    if(j % 2 != 0)
                    {
                        uneven += B[i, j];
                    }
                }
            }

            Console.WriteLine("Minimum element = {0}", min_B);
            Console.WriteLine("Maximum element = {0}", max_B);
            Console.WriteLine("Sum: {0}", sum_B);
            Console.WriteLine("Product: {0}", prod_B);
            int min_C = min_A < min_B ? min_A : min_B;
            int max_C = max_A > max_B ? max_A : max_B;
            Console.WriteLine("\nTotal minimum element = {0}", min_C);
            Console.WriteLine("Total maximum element = {0}", max_C);
            int sum_C = sum_A + sum_B;
            long prod_C = (long)prod_A * prod_B;
            Console.WriteLine("Total sum = {0}", sum_C);
            Console.WriteLine("Total product = {0}", prod_C);
            Console.WriteLine("Sum of even numbers (array A) = {0}", even);
            Console.WriteLine("Sum of uneven number columns (array B) = {0}", uneven);
            Console.WriteLine();
        }
    }
}
