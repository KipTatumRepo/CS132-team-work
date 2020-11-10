/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 06 
**Date: 2020-09-11
**Description: program to manipulate and display a double in different ways
*********/
using System;

namespace NumOut
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare the double
			double givenVariable = 987654.321d;
			string sGivenVariable = givenVariable.ToString(); //create the string representation of the double to manipulate it

			Console.WriteLine($"{givenVariable} with an extra \".\" in it");
			Console.WriteLine(sGivenVariable.Insert(3, ".")); //insert the "." after 7

			Console.WriteLine($"{givenVariable} displayed as an integer");
			Console.WriteLine(Convert.ToInt32(givenVariable)); //convert double into a variable

			Console.WriteLine($"{givenVariable} displayed as US currency");
			Console.WriteLine(givenVariable.ToString("C")); //pass "C" to ToString() to show as currency 
			Console.ReadKey();
		}
	}
}
