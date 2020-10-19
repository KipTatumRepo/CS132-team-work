/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 03
**Date: 2020-19-10
**Description: a program to generate two random numbers and perform various
** operations on them.
*********/
using System;

namespace Randoms
{
	class Program
	{
		static void Main(string[] args)
		{
			//set the constants for minimum and maximum values
			const int MIN = 1;
			const int MAX = 100;

			//create one instance of the random object
			Random randomNumber = new Random();

			//declare and assign the variables to be random nubmers between 1 and 100 
			int a = randomNumber.Next(MIN, MAX);
			int b = randomNumber.Next(MIN, MAX);

			//display the created random number
			Console.WriteLine("The value of the first random number is:{0}", a);
			Console.WriteLine("The value of the second random number is:{0}", b);


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
