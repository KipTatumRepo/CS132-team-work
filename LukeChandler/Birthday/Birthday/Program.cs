/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE07 Exercise 3 
**Date: 2020-11-21
**Description: Playing around with DateTime object related to my birthday
*********/

using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            //Following Example 7-2 from Textbook
            //Constant declaration
            const int YEAR = 1986, MONTH = 12, DAY = 7, HOUR = 20, MINUTE = 41, SECOND = 11;

            DateTime birthDay = new DateTime(YEAR, MONTH, DAY, HOUR, MINUTE, SECOND);
            ShowBirthday(birthDay);
            Console.ReadLine();
        }

        public static void ShowBirthday(DateTime dt)
        {
            //Display all the properties of birthday
            Console.Write("I was born in the ");
            Console.WriteLine("Year: " + dt.Year);
            Console.WriteLine("Month: " + dt.Month);
            Console.WriteLine("Day: " + dt.Day);
            Console.WriteLine("Day of the Week: " + dt.DayOfWeek);
            Console.WriteLine("Day of the Year: " + dt.DayOfYear);
            Console.Write("Hours: " + dt.Hour);
            Console.Write(" Minutes: " + dt.Minute);
            Console.Write(" Seconds: " + dt.Second);
            Console.WriteLine("\nThe Birthday in long date format is: " + dt.ToLongDateString());
        }
    }
}
