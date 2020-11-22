/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE07 Exercise 2 
**Date: 2020-11-21
**Description: Creating a 2 TimeSpan objects(programming and testing) add and compare
*********/

using System;

namespace TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
			//Instatiate the 2 TimeSpan Objects one for programming time per week and one for testing time per week
			TimeSpan programmingTimePerWeek = new TimeSpan(22, 34, 11);
			TimeSpan testingTimePerWeek = new TimeSpan(12, 7, 55);

			//TimeSpan Object that is the addition of programming and testing per week
			TimeSpan cumulativeDevTime = programmingTimePerWeek + testingTimePerWeek;

			//Variable for display purposes
			int cumulativeHours = (int)cumulativeDevTime.TotalHours; //Casting as a int
			int cumulativeMinutes = cumulativeDevTime.Minutes;
			int cumulativeSeconds = cumulativeDevTime.Seconds;

			//Output result of Cumulative Dev Time
			Console.WriteLine("Cumulative Dev Time this week: {0}hrs {1}mins {2}secs", cumulativeHours, cumulativeMinutes, cumulativeSeconds);

			//Compare programming and testing TimeSpan Objects
			if (programmingTimePerWeek > testingTimePerWeek)
			{
				Console.WriteLine("More time was spent this week on programming than testing.");
			}
			else
				Console.WriteLine("More time was spent on testing than programming this week.");
		}
    }
}
