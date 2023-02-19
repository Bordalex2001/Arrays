using System;

namespace Homework
{
    class Task4
    {
        static void CreateMatrix(int r, int c)
        {
            int[,] matrix = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Index [{i}][{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    //Console.Write(matrix[i, j].ToString());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MultiplyByNumber(int[,] printMatrix)
        {
            int m = 0;
            Console.Write("Enter multiplier: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: \n");
            for (int i = 0; i < matr.GetLength(0); i++)                      //умножаем матрицу на число и выводим
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] *= num;
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void AddMatrices()
        {
            for (int i = 0; i < matr.GetLength(0); i++)            //сложение матриц
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] += matr2[i, k];
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void MultiplyMatrices()
        {
            for (int i = 0; i < matr.GetLength(0); i++)            //перемножение матриц
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] *= matr2[i, k];
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("Create and fill a matrix with any numbers");
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            int columns = int.Parse(Console.ReadLine());
            CreateMatrix(rows, columns);
            Console.Write("Choose an operation: ");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    MultiplyByNumber();
                    break;
                case 2:
                    CreateMatrix(rows, columns);
                    AddMatrices();
                    break;
                case 3:
                    CreateMatrix(rows, columns);
                    MultiplyMatrices();
                    break;
            }
        }
    }
}