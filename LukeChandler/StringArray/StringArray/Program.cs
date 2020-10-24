/********
**Name: Chandler, Luke
**Class: CS 132
**Project: StringArray PE02 Part 2
**Date: 10-18-2020
**Description: A Program that declared an arrary with 4 string elements and sorts the array.
**Then outputs the number of the array elements and the sorted element values
*********/

using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
			//Declaring an array with 4 string elements
			string[] stringArray = new string[4] { "January", "April", "August", "December" };

			//Outputting the number of elements in the array
			Console.WriteLine("In the array, there are " + stringArray.Length + " elements!");

			//Sorting the Array
			Array.Sort(stringArray);

			//Outputting the sorted elements of the String array
			Console.WriteLine("The Elements in the array sorted Alphabetically are, " +
							  stringArray[0] + ", " +
							  stringArray[1] + ", " +
							  stringArray[2] + ", " +
							  stringArray[3] + ".");
			Console.ReadKey();
		}
    }
}
