/********
**Name: Chandler, Luke
**Class: CS132
**Project: Random PE06 Exercise 4
**Date: 11-14-2020
**Description: A program that modifies Expression project from Chapter 3
*********/

using System;

namespace ExpressionModified
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring 2 variables of type int with values of 100 and 20 respectively
            int a;
            int b;

            //User Input
            Console.WriteLine("Enter an integer value!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer value!");
            b = Convert.ToInt32(Console.ReadLine());

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
