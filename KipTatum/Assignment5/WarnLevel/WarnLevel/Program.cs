/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 05 
**Date: 2020-02-11
**Description:  A program to various messages based on the parameters
** passed to the method
*********/
using System;

namespace WarnLevel
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayMessage(0, true); // expect first if
			DisplayMessage(1, false); //expect nothing found to print
			DisplayMessage(1, true); //expect print first else if
			DisplayMessage(-22, false); //expect  second else if
			DisplayMessage(4582168, false); //expect last esle if
			DisplayMessage(-28, true); //expect last else if
			Console.ReadKey();
		}

		static void DisplayMessage(int input, bool b) 
		{
			if (input == 0 && b == true)
			{
				Console.WriteLine("Nothing to see here.");
			}
			else if (input == 1 && b == true)
			{
				Console.WriteLine("Getting closer to seeing something.");
			}
			else if (input < 0 && b == false)
			{
				Console.WriteLine("You can't realistically have less than 0 items in your hand.");
			}
			else if (input > 1 || b == true)
			{
				Console.WriteLine("Jackpot!!! You found something.");
			}
			else
			{
				Console.WriteLine("Nothing found");
			}
		}
	}
}
