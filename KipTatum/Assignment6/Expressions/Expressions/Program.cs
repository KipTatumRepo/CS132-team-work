/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 03
**Date: 2020-09-11
**Description: a program to perform various expressions on two numbers input by the user.
*********/
using System;

namespace Expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare variables
			int a;
			int b;

			//get user input and assign to variables
			Console.WriteLine("Enter a value to perform math operations on: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter another value to perform math operations on: ");
			b = Convert.ToInt32(Console.ReadLine());

			//perform arithmetic operations on the given variables and output the answers
			Console.WriteLine("\n**********Results***********");
			Console.WriteLine("Addition:        {0} + {1} = {2}", a, b, a + b);
			Console.WriteLine("Subtraction:     {0} - {1} = {2}", a, b, a - b);
			Console.WriteLine("Multiplication:  {0} * {1} = {2}", a, b, a * b);
			Console.WriteLine("Division:        {0} / {1} = {2}", a, b, a / b);
			Console.WriteLine("Remainder:       {0} % {1} = {2}", a, b, a % b);
			Console.ReadKey();
		}
	}
}
