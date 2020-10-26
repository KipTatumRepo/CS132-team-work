/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 04 
**Date: 2020-26-10
**Description: program to show how scope affects variables.  I am not sure
** if this is exactly what you want, but in ScopeDemo() we cannot name the 
** variable the same name even if it is in the if statement
*********/
using System;

namespace ScopeLevels
{
	class Program
	{
		
		static void Main(string[] args)
		{
			//variable declaration
			int classAndMethodLevel = 3;
			int classAndBlockLevel = 4;

			//output
			Console.WriteLine($"Class Level In Main: {classAndMethodLevel}");
			Console.WriteLine($"Class Level In Main: {classAndBlockLevel}");
			ScopeDemo();
			Console.ReadKey();
		}

		/** Method Creation **/
		static void ScopeDemo()
		{
			//set a boolean to ensure we enter a block of code
			const bool ENTER_CONDITION = true; 
			int classAndMethodLevel = 5; 

			Console.WriteLine($"Method Level In Scope Demo Method: {classAndMethodLevel}");
			
			if (ENTER_CONDITION)
			{
				int classAndBlockLevel = 6;
				Console.WriteLine($"Block Level In Scope Demo Method: {classAndBlockLevel}");
			}
		}
	}
}
