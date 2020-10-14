/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 02 part 1
**Date: 2020-10-12
**Description: program that will display various variables
*********/
using System;

namespace Types
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare and initialize the variables
			int wholeNumber = 77;
			float decimalNumber = 22.25F;
			string stringNumber = "Value 100";
			int floatToInt = (int)decimalNumber; //casting a float to an int

			//dislay the variables
			Console.WriteLine("A whole number: " + wholeNumber);
			Console.WriteLine("A number with a decimal: " + decimalNumber);
			Console.WriteLine("A string representation of a number: " + stringNumber);
			Console.WriteLine("Converting a float to an integer: " + floatToInt);
			Console.ReadKey();

			//when a number is cast from a double to an int, the decimal part of the double is truncated

		}
	}
}
