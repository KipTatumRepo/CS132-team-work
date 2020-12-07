/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 10 
**Date: 2020-07-12
**Description:  This program will print out the colors of a list, substitute a color in the list,
** add a color to the list and verify that color has been added to the list.
*********/
using System;
using System.Collections.Generic;
namespace ColorList
{
	class Program
	{
		//this method will print out the items in a given list
		//I did the method like this so I did not have to keep building a foreach loop
		//each time I wanted to print out the list of colors
		private static void Print(List<string> l)
		{
			foreach (string s in l)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine();
		}

		//this method will print out the item if it is in the list
		//I created this method since we are checking for a color more than once.
		private static void CheckForColor(string c, List<string> l)
		{
			if (l.Contains(c))
			{
				Console.WriteLine($"The list contains {c}");
			}
		}
		
		static void Main(string[] args)
		{
			//create a Colors List<string> object and add colors to it
			List<string> Colors = new List<string>();
			Colors.Add("White");
			Colors.Add("Red");
			Colors.Add("Orange");
			Colors.Add("Yellow");
			Colors.Add("Green");
			Colors.Add("Blue");
			Colors.Add("Indigo");
			Colors.Add("Violet");
			Colors.Add("Black");

			//print out each of the colors
			Print(Colors);

			//get and display the size of the colors list
			int listSize = Colors.Count;
			Console.WriteLine("The color list has {0} items\n", listSize);

			//alphabetically sort the colors list and print it out
			Console.WriteLine("The list of colors has been alphabetically sorted");
			Colors.Sort();
			Print(Colors);

			//find where the string Violet is, substitute Purple for it and print out the new list
			Console.WriteLine("Violet has been removed and Purple is now in its place");
			int index = Colors.IndexOf("Violet");
			Colors.RemoveAt(index);
			Colors.Insert(index, "Purple");
			Print(Colors);

			//check to see if magenta is in the list of colors
			CheckForColor("Magenta", Colors);

			//add magenta to the list of colors
			Colors.Add("Magenta");

			//print out new list with magenta added to it
			Console.WriteLine("We have added Magenta to the list of colors");
			Print(Colors);

			//check again to see if magenta is in the list of colors
			CheckForColor("Magenta", Colors);
			Console.ReadKey();

			//Magenta is added to the end of the list.  When you add a new item to a List it
			//will be added to the end.  we have the Insert method to add an item to a 
			//particular spot in the list if needed.
		}
	}
}
