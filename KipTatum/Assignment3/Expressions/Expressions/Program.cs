﻿/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 03
**Date: 2020 - 19 - 10
**Description: a program to perform various expressions on two numbers.
*********/
using System;

namespace Expressions
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 100;
			int b = 20;

			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
			Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
			Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
			Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
			Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
			Console.ReadKey();
		}
	}
}