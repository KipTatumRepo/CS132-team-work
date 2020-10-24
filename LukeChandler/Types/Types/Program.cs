/********
**Name: Chandler, Luke
**Class: CS132
**Project: Types PE02 Part 1
**Date: 10-18-2020
**Description: A program playing with data types in C#
*********/

using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
			//First we need to declare and initialize the 4 variables
			//Integer variable with a value of 77
			int integerNumber = 77;
			//Float variable with a value of 22.25
			float numberWithDecimalPlaces = 22.25F;
			//String variable with a value of "Value 100"
			string descriptionOfNumberValue = "Value 100";
			//Variable casting numberWithDecimalPlaces to an Integer
			int floatToInteger = (int)numberWithDecimalPlaces;

			//Output of the values of all four variables
			Console.WriteLine("Integer number: " + integerNumber);
			Console.WriteLine("Number with a decimal places: " + numberWithDecimalPlaces);
			Console.WriteLine("String description of the value of a number: " + descriptionOfNumberValue);
			Console.WriteLine("Converting a float to an integer: " + floatToInteger);
			Console.ReadKey();

			//Question: What happens to the number when you cast a double to an integer?
			//Answer: When you cast a double to an integer, it cuts off the decimpal portion of the double
		}
	}
}
