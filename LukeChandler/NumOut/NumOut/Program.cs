/********
**Name: Chandler, Luke
**Class: CS132
**Project: Random PE06 Exercise 1
**Date: 11-14-2020
**Description: A program to play with the ToString method with a double variable
*********/

using System;

namespace NumOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable of type double
            double doubleNumber = 987654.321d;
            Console.WriteLine("Original Double Variable = 987654.321");
            //Double variable ToString
            string doubleNumberToString = doubleNumber.ToString();
            //Print out the doubleNumber variable with 2 decimal points
            Console.WriteLine("Original Double Variable with 2 decimal points");
            Console.WriteLine(doubleNumberToString.Insert(8, "."));
            //Print out the doubleNumber variable in integer form
            Console.WriteLine("Original Double Variable as an integer");
            Console.WriteLine(Convert.ToUInt32(doubleNumber));
            //Print out the doubleNumber variable as a currency value
            Console.WriteLine("Original Double Variable as a currency value");
            //https://www.tutorialspoint.com/chash-currency-c-format-specifier#:~:text=The%20%22C%22%20(or%20currency,C3%E2%80%9D)%20currency%20format%20specifier.
            Console.WriteLine(doubleNumber.ToString("C"));
            Console.ReadKey;
        }
    }
}
