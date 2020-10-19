/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 03
**Date: 2020 - 19 - 10
**Description: a program to perform binary operations on two numbers.
*********/
using System;

namespace BinaryOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare and assign the variables
			int a = 100;
			int b = 20;

			//I wasn't sure if we should reassign the value of 'a' back to
			//its original value of 100 each time.  In this case 'a' just keeps is
			//always equal to the result of the previous operation and never 
			//reassigned back to 100, unless that is the result of the operation.
			//I also thought it made the code a bit more concise to include the operation
			//in the WriteLine method
			Console.WriteLine("The value of a is now:{0}", a += b);
			Console.WriteLine("The value of a is now:{0}", a -= b);
			Console.WriteLine("The value of a is now:{0}", a *= b);
			Console.WriteLine("The value of a is now:{0}", a /= b);
			Console.WriteLine("The value of a is now:{0}", a %= b);
			Console.ReadKey();
		}
	}
}
