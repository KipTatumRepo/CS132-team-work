/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 07 
**Date: 2020-17-11
**Description: A program to compare 2 timespans, display their totals added together
** and to display if programming time is greater or less than testing time
*********/
using System;

namespace TimeSpan2
{
	class Program
	{
		static void Main(string[] args)
		{
			//instantiate to TimeSpan objects with different times
			TimeSpan weeklyProgrammingTime = new TimeSpan(30,15,33);
			TimeSpan weeklyTestingTime = new TimeSpan(8,55,45);

			//instatiate TimeSpan that is the sum of the previous 2 objects
			TimeSpan totalDevelopmentTime = weeklyProgrammingTime.Add(weeklyTestingTime); 

			//create variable to display hrs minutes and seconds in a nice format
			int totalHours = (int)totalDevelopmentTime.TotalHours; //we want a whole value of the total hrs that is why it is converted to int
			int totalMins = totalDevelopmentTime.Minutes;
			int totalSecs = totalDevelopmentTime.Seconds;

			//print results of the add operation
			Console.WriteLine("Total development and testing time: {0}hrs {1}mins {2}secs\n", totalHours, totalMins, totalSecs);

			//compare the two created TimeSpan objects
			int compare = weeklyProgrammingTime.CompareTo(weeklyTestingTime);

			//based on compare result display the proper message
			switch (compare)
			{
				case 1:
					Console.WriteLine("You programmed more than you tested this week!");
					break;
				case 0:
					Console.WriteLine("You spent equal time programming and testing this week!");
					break;
				case -1:
					Console.WriteLine("You tested more than you programmed this week!");
					break;
			}
			Console.ReadKey();
		}
	}
}
