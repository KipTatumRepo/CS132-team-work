/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 07 
**Date: 2020-17-11
**Description: A program that will display an instaniated TimeSpan
** objects Hour, Minute and Second properties
*********/
using System;

namespace TimeSpan1
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare constant to pass to a TimeSpan object
			const int HRS = 11, MIN = 10, SEC = 13;

			//Instantiate the TimeSpan object
			TimeSpan time = new TimeSpan(HRS, MIN, SEC);

			//Output wanted properties
			Console.WriteLine("TimeSpan object constant hour: " + time.Hours);
			Console.WriteLine("TimeSpan object constant minute: " + time.Minutes);
			Console.WriteLine("TimeSpan object constant minute: " + time.Seconds);
			Console.ReadKey();
		}
	}
}
