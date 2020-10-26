/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 04 
**Date: 2020-26-10
**Description: program to show how variables passed by
** reference act
*********/
using System;

namespace RefVal
{
	class Program
	{
		static void Main(string[] args)
		{
			//variable declaration
			float firstNumber = 5.0f;
			float secondNumber = 6.0f;

			//display original values
			Console.WriteLine("Values PRIOR to passing to PassByRefExample method");
			Console.WriteLine($"First Number: {firstNumber}      Second Number: {secondNumber}\n");

			//perform the addition to update the variables
			PassByRefExample(ref firstNumber, ref secondNumber);

			//dispaly updated values
			Console.WriteLine("Values AFTER passing to PassByRefExample method");
			Console.WriteLine($"First Number: {firstNumber}     Second Number: {secondNumber}");
			Console.ReadKey();
		}
		/** Method Creation Section **/

		//This method will take 2 floats in by reference update those floats to new values
		static void PassByRefExample(ref float firstNumber, ref float secondNumber)
		{
			firstNumber += 6.3f;
			secondNumber += 14.2f;
		}
	}
}
