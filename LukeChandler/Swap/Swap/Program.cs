/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE10E01 
**Date: 2020-12-08
**Description: Program that takes in two values of different types and then swaps them
*********/

using System;

namespace Swap
{
    class Program
    {
			static void Swap<T>(ref T a, ref T b)
			{
				//Displaying the values without swapping them
				Console.WriteLine("Value of the first value is {0}", a);
				Console.WriteLine("Value of the second value is {0}", b);

				//Swap the values of a and b
				T temp = a;
				a = b;
				b = temp;

				//Displaying the values after swapping them
				Console.WriteLine("Now, the value of the first value is {0}", a);
				Console.WriteLine("Now, the value of the second value is {0}", b);
			}

			static void Main(string[] args)
			{
				int firstValueInt = 1986;
				int secondValueInt = 2020;
				string firstValueString = "Birth Year";
				string secondValueString = "Current Year";

				Swap<int>(ref firstValueInt, ref secondValueInt);

				Console.WriteLine();

				Swap<string>(ref firstValueString, ref secondValueString);

				Console.ReadLine();

			}
		
    }
}
