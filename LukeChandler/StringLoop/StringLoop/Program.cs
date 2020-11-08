/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE05 Exercise 3
**Date: 2020-11-06
**Description: For loop to print out the values in a string array
*********/

using System;

namespace StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing a array off type string with different colors at indexes 0 - 5
            string[] colors = new string[] { "red", "white", "blue", "green", "gold", "pink" };

            //For Loop to print out the values in the string array
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Element[" + i + "] = " + colors[i]);
            }
        }
    }
}
