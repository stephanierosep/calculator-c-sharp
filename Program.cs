﻿using System;

namespace WorkingCSharpProject
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
              Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
              Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
              Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
              Console.WriteLine(num1 / num2);
            } else
            {
              Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();


        }

    }
}
