/********
**Name: Chandler, Luke
**Class: CS132
**Project: BinaryOperators PE03 Part 2
**Date: 10-24-2020
**Description: A program using binary operators in C#
*********/

using System;

namespace BinaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 2 variables of type integer with values of 100 and 20 respectively
            int a = 100;
            int b = 20;

            Console.WriteLine("A is equal to 100. B is equal to 20");
            a += b; 
            Console.WriteLine("Addition of a plus b. The value of a is now: {0}", a);
            a -= b;
            Console.WriteLine("Subtraction of a minus b. The value of a is now: {0}", a);
            a *= b;
            Console.WriteLine("Multiplication of a times b. The value of a is now: {0}", a);
            a /= b;
            Console.WriteLine("Division of a divided by b. The value of a is now: {0}", a);
            a %= b;
            Console.WriteLine("Remainder of a divided by b. The value of a is now: {0}", a);

            Console.ReadKey();
        }
    }
}
