/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 06 
**Date: 2020-09-11
**Description: program to compare 2 strings and display a message letting the user know if
** the strings are equal or not
*********/
using System;

namespace CompareString
{
	class Program
	{
		static void Main(string[] args)
		{
			bool stringCompareResult; //declare a bool variable to get result of StringCompare()
			bool stringCompareResult2; //declare a bool variable to get result of StringCompare()
			
			stringCompareResult = StringCompare("Hello", "hello");
			//depending results of StringCompare() display proper message
			if (stringCompareResult)
			{
				Console.Write("MATCH.\n");
			}
			else
			{
				Console.Write("DO NOT MATCH.\n");
			}

			stringCompareResult2 = StringCompare("Goodbye", "There");
			//depending results of StringCompare() display proper message
			if (stringCompareResult2)
			{
				Console.Write("MATCH.\n");
			}
			else
			{
				Console.Write("DO NOT MATCH.\n");
			}

			Console.ReadKey();
		}

		//This method will compare two strings regardless of casing and return true if
		//they are the same and false if they are not
		public static bool StringCompare(string one, string two)
		{
			string lowerOne = one.ToLower();
			string lowerTwo = two.ToLower();
			Console.Write($"{one} and {two} ");
			return lowerOne.Equals(lowerTwo);
		}
	}
}
