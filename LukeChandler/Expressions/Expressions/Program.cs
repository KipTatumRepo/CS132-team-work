/********
**Name: Chandler, Luke
**Class: CS132
**Project: Expressions PE03 Part 1
**Date: 10-24-2020
**Description: A program using mathematic operations in C#
*********/

using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring 2 variables of type int with values of 100 and 20 respectively
            int a = 100;
            int b = 20;

            //Addition
            Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a + b);
            //Subtraction
            Console.WriteLine("Subtraction: {0} - {1} = {2}", a, b, a - b);
            //Multiplication
            Console.WriteLine("Multiplication: {0} * {1} = {2}", a, b, a * b);
            //Division
            Console.WriteLine("Division: {0} / {1} = {2}", a, b, a / b);
            //Remainder
            Console.WriteLine("Remainder: {0} % {1} = {2}", a, b, a % b);
            Console.ReadKey();
        }
    }
}
