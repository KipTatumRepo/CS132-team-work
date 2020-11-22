/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 07 
**Date: 2020-17-11
**Description:  program that will display properties of a DateTime object
*********/
using System;

namespace Birthday
{
	class Program
	{
		static void Main(string[] args)
		{
			//define constants
			const int YR = 1978, MTH = 10, DAY = 11, HRS = 11, MIN = 22, SEC = 44;
			const string NAME = "Kip";

			//instantiate DateTime with constant parameters
			DateTime bDay = new DateTime(YR, MTH, DAY, HRS, MIN, SEC);
			string append = DayOfYearAppend(bDay.DayOfYear); //assign value to append to the day of the year

			//output the various property values of the DateTime object
			Console.WriteLine($"{NAME}'s birth year is: " + bDay.Year);
			Console.WriteLine($"{NAME}'s birth month is: " + bDay.Month);
			Console.WriteLine($"{NAME}'s birth day is: " + bDay.Day);
			Console.WriteLine($"{NAME} was born on a " + bDay.DayOfWeek);
			Console.WriteLine("That was the " + bDay.DayOfYear + $"{append} day of the year in {YR}");
			Console.Write($"{NAME} was born at ");
			Console.Write(bDay.Hour + ":");
			Console.Write(bDay.Minute + ":");
			Console.Write(bDay.Second + "\n");

			//output the 2 ways to show long date format
			Console.WriteLine($"{NAME}'s birthday in long format is " + bDay.ToLongDateString() + " (created using C# built in method ToLongDateString())");
			Console.WriteLine($"{NAME}'s birthday in long format is " + bDay.ToString("D") + " (created using DateTime Format Specifiers)");
			Console.ReadKey();
		}

		//This method will take in the day number of the year and return the correct
		//string to append to the end 
		public static string DayOfYearAppend(int day)
		{
			int result = day % 10; 

			//depending on the remainder value from the above modulo operation select the correct string to return
			switch (result)
			{
				case 1:
					return "st";
					break;
				case 2:
					return "nd";
					break;
				case 3:
					return "rd";
					break;
				default:
					return "th";
					break;
			}
		}
	}
}
