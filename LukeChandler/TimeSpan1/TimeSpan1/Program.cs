/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE07 Exercise 1 
**Date: 2020-11-21
**Description: Creating a TimeSpan object to display day, hour, minute and seconds
*********/

using System;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Following Example 7-1 from the Textbook
            //First declaring a constant to pass to the TimeSpan object
            const int DAY = 7, HRS = 18, MINS = 45, SECS = 55;

            //Creating a TimeSpan object
            TimeSpan ts = new TimeSpan(DAY, MINS, HRS, SECS);
            Console.WriteLine(ts.Days + " days "
                            + ts.Hours + " hours "
                            + ts.Minutes + " minutes "
                            + ts.Seconds + " seconds ");

            //Displaying the Days, Hours, Minutes, and Seconds
            Console.WriteLine("Days from the TimeSpan: " + ts.TotalDays);
            Console.WriteLine("Hours from the TimeSpan: " + ts.TotalHours);
            Console.WriteLine("Minutes from the TimeSpan: " + ts.TotalMinutes);
            Console.WriteLine("Seconds from the TimeSpan: " + ts.TotalSeconds);
            Console.ReadKey();
        }
    }
}
