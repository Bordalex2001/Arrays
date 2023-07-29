using System;

namespace Homework
{
    class Task4
    {
        static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Index [{i}][{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    //Console.Write(matrix[i, j].ToString());
                }
            }
            return matrix;
        }
        static void ShowMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] MultiplyByScalar(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)                      
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int columnsB = matrixB.GetLength(1);
            if (rowsA != rowsB || columnsA != columnsB)
            {
                Console.WriteLine("Sizes of these matrices are not equal");
            }
            int[,] result = new int[rowsA, columnsA];
            for (int i = 0; i < rowsA; i++)            
            {
                for (int j = 0; j < columnsA; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
        }
        static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int columnsB = matrixB.GetLength(1);
            if (columnsA != rowsB)
            {
                Console.WriteLine("Number of the first matrix columns is not equal to number of the second matrix rows");
            }
            int[,] result = new int[rowsA, columnsB];
            for (int i = 0; i < rowsA; i++)            
            {
                for (int j = 0; j < columnsB; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Enter parameters for the first matrix");
            Console.Write("Rows: ");
            int rowsA = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            int columnsA = int.Parse(Console.ReadLine());
            int[,] matrixA = CreateMatrix(rowsA, columnsA);
            Console.WriteLine();
            ShowMatrix(matrixA);
            Console.WriteLine();
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Multiplying the matrix by a number");
            Console.WriteLine("2. Matrix addition");
            Console.WriteLine("3. Matrix multiplication");
            int operation = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (operation)
            {
                case 1:
                    Console.Write("Enter a number or a scalar by which to multiply the matrix ");
                    int scalar = int.Parse(Console.ReadLine());
                    int[,] resultMultByScalar = MultiplyByScalar(matrixA, scalar);
                    ShowMatrix(resultMultByScalar);
                    break;
                case 2:
                    Console.WriteLine("Enter parameters for the second matrix");
                    Console.Write("Rows: ");
                    int rowsB1 = int.Parse(Console.ReadLine());
                    Console.Write("Columns: ");
                    int columnsB1 = int.Parse(Console.ReadLine());
                    int[,] matrixB1 = CreateMatrix(rowsB1, columnsB1);
                    Console.WriteLine();
                    ShowMatrix(matrixB1);
                    Console.WriteLine();
                    int[,] resultAddition = AddMatrices(matrixA, matrixB1);
                    ShowMatrix(resultAddition);
                    break;
                case 3:
                    Console.WriteLine("Enter parameters for the second matrix");
                    Console.Write("Rows: ");
                    int rowsB2 = int.Parse(Console.ReadLine());
                    Console.Write("Columns: ");
                    int columnsB2 = int.Parse(Console.ReadLine());
                    int[,] matrixB2 = CreateMatrix(rowsB2, columnsB2);
                    Console.WriteLine();
                    ShowMatrix(matrixB2);
                    Console.WriteLine();
                    int[,] resultMultiplication = MultiplyMatrices(matrixA, matrixB2);
                    ShowMatrix(resultMultiplication);
                    break;
            }
            Console.WriteLine();
        }
    }
}