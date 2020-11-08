/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 05 
**Date: 2020-02-11
**Description: A program that will continue to work until
** told to exit by the user
*********/
using System;

namespace GoOrQuit
{
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true; //we will update this when user has chosen to exit
			while(run) 
			{
				CreateMenu();
				string input = Console.ReadLine();
				Console.WriteLine();
				
				//user has chosen to exit we need to update the boolen and print 
				//good-bye message
				if (input == "2")
				{
					run = false;
					Console.WriteLine("Bye Bye.  Press any key to exit.");
				}
			}
			Console.ReadKey();
		}
		//This method creates a simple menu with 2 options for a user to select from
		static void CreateMenu()
		{
			Console.WriteLine("Program is Running");
			Console.WriteLine("Select an option");
			Console.WriteLine("1. Keep running the loop");
			Console.WriteLine("2. Stop the loop");
			
		}
	}
}
