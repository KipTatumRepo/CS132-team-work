/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 02 part 2
**Date: 2020-10-12
**Description: a program to display the number of elements and sorted contents of an array of strings
*********/
using System;

namespace StringArray
{
	class Program
	{
		static void Main(string[] args)
		{
			//declaring and initializing an array of unordered strings
			string[] stringArray = new string[4] { "4th String", "First String", "Another String", "String Number Three" };

			//display the number strigns in the array
			Console.WriteLine("There are " + stringArray.Length + " elements in the array");

			//sort the array alphabetically
			Array.Sort(stringArray);

			//display the sorted elements of the array
			Console.WriteLine(stringArray[0] + ", " +
							  stringArray[1] + ", " +
				              stringArray[2] + ", " +
				              stringArray[3]);
			Console.ReadKey();
		}
	}
}
