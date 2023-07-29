using System;

namespace Homework
{
    class Task5
    {
        static void Main()
        {
            Console.Write("Enter an expression: ");
            string input = Console.ReadLine();
            int result = Calculate(input);
            Console.WriteLine("Result: " + result);
        }
        static int Calculate(string expression)
        {
            int result = 0;
            int number = 0;
            char signOfOperation = '+';
            bool operationIsSupported = false;
            for (int i = 0; i < expression.Length; i++)
            {
                char symb = expression[i];
                if (char.IsDigit(symb))
                {
                    number = number * 10 + (symb - '0');
                }
                else if (symb == '+' || symb == '-')
                {
                    if (operationIsSupported)
                    {
                        result = ExecuteOperation(result, number, signOfOperation);
                    }
                    else
                    {
                        result = number;
                    }
                    number = 0;
                    signOfOperation = symb;
                    operationIsSupported = true;
                }
            }
            if (operationIsSupported)
            {
                result = ExecuteOperation(result, number, signOfOperation);
            }
            else
            {
                result = number;
            }
            return result;
        }
        static int ExecuteOperation(int left_operand, int right_operand, char operator_sign)
        {
            if (operator_sign == '+')
            {
                return left_operand + right_operand;
            }
            else if (operator_sign == '-')
            {
                return left_operand - right_operand;
            }
            else
            {
                return 0;
            }
        }
    }
}