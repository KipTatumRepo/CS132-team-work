/********
**Name: Chandler, Luke
**Class: CS132
**Project: Random PE06 Exercise 3
**Date: 11-14-2020
**Description: A program that compares strings (2) and returns true or false
*********/

using System;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            //First example is Hello and hello
            Console.WriteLine("Two Strings are Hello and hello");
            if (CompareStrings("Hello", "hello"))
            {
                Console.Write("Strings Match!\n");
            }
            else
            {
                Console.WriteLine("Strings don't Match...\n");
            }

            //Second example is Results and Election
            Console.WriteLine("Two Strings are Results and Election");
            if (CompareStrings("Results", "Election"))
            {
                Console.Write("Strings Match!\n");
            }
            else
            {
                Console.WriteLine("Strings don't Match...\n");
            }

        }
        //Method for checking if the 2 strings are the same
        public static bool CompareStrings(string first, string second)
        {
            //make both the first and second strings to all Caps
            string firstCaps = first.ToUpper();
            string secondCaps = second.ToUpper();
            //Whether they are equal or not
            if (firstCaps.Equals(secondCaps))
            {
                return true;
            }
            else
                return false;
        }
    }
}
