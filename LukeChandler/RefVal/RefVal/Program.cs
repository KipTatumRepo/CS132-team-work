/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE04 Exercise 2
**Date: 2020-10-30
**Description: Method taking 2 arguments passed by reference and display before and after"
*********/

using System;

namespace RefVal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring 2 float variables
            float piAbbreviated = 3.14f;
            float almostPerfect = 99.9f;

            //Display the variable before passing them to method
            Console.WriteLine($"Before passing variables to the method, Pi: {piAbbreviated} and Almost Perfect: {almostPerfect}");

            //Passing the values to the method by reference
            PassByReference(ref piAbbreviated, ref almostPerfect);

            //Display modified float values after passing them by reference to method
            Console.WriteLine($"After passing variables to the method by reference, Pi= {piAbbreviated} and Almost Perfect= {almostPerfect}");
            Console.ReadKey();
        }

        //Defining the method that will take in the 2 float values and update them
        static void PassByReference(ref float a, ref float b)
        {
            const float Modify = 89.23f;
            a *= Modify;
            b *= Modify;
        }

    }
}
