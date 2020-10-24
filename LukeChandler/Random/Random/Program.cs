/********
**Name: Chandler, Luke
**Class: CS132
**Project: Random PE03 Part 3
**Date: 10-24-2020
**Description: A program using mathematic operators with random numbers in C#
*********/

using System;

namespace Randoms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the minimum and maximum bounds for the random numbers
            const int MIN = 1;
            const int MAX = 100;

            //Instantiate the random number object
            Random randomNum = new Random();

            //Declare two variables with random values between the MIN and MAX bounds set in line 18-19
            //Print out what the random values are
            int a = randomNum.Next(MIN, MAX);
            int b = randomNum.Next(MIN, MAX);
            Console.WriteLine("The first random value is {0}.", a);
            Console.WriteLine("The second random value is {0}.", b);

            //Now perform some mathematic operations using the randomly generated numbers
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
