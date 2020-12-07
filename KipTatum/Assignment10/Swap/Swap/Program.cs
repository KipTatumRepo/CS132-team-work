/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 10 
**Date: 2020-07-12
**Description: A program to take 2 inputs of different types and swap them
*********/
using System;

namespace Swap
{
	class Program
	{
		//This method switches around two given values, we are passing by reference so we actually
		//change the variables in memory, not a copy of the variables
		static void Swap<T>(ref T a, ref T b)
		{
			//display values as originally pass
			Console.WriteLine("Values as originally passed.");
			Console.WriteLine($"The first value passed in is {a}");
			Console.WriteLine($"The second value passed in is {b}");

			//Do the work or swapping the values
			T temp = a;
			a = b;
			b = temp;

			//print out the swapped variables since we passed by reference the variables in memory
			//have been changed
			Console.WriteLine("\nNow we have swaped the variables.");
			Console.WriteLine($"The first value is {a}");
			Console.WriteLine($"The second value is {b}");
		}
			
		static void Main(string[] args)
		{
			int firstInt = 7608;
			int secondInt = 1251;
			string firstString = "Hello";
			string secondString = "World";

			Swap<int>(ref firstInt, ref secondInt); 
			Console.WriteLine();
			Swap<string>(ref firstString, ref secondString);
			Console.ReadKey();
			
		}
	}
}
