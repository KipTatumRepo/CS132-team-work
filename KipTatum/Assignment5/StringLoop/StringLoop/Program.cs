/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 05 
**Date: 2020-02-11
**Description:  A program to iterate of the elements of a string array
** and print out each element
*********/
using System;

namespace StringLoop
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = new string[3] { "This", "That", "The Other"};

			//I used a foreach loop because we need to show all the elements of the
			//array
			foreach (string item in stringArray)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
	}
}
