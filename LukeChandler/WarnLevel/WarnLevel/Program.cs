/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE05 Exercise 1 and 2
**Date: 2020-11-06
**Description: Playing with if...else statements and AND/OR operators
*********/


using System;

namespace WarnLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Running the different Scenerios

            //Expected: Warning Level is Low! 
            WarningLevel(1, false);
            //Expected: False Alarm
            WarningLevel(1, true);
            //Expected: Warning Level is Medium!
            WarningLevel(2, false);
            //Expected: False Alarm
            WarningLevel(2, true);
            //Expected: Warning Level is High!
            WarningLevel(3, false);
            //Expected: False Alarm
            WarningLevel(3, true);
            //Expected: No Warning!
            WarningLevel(0, false);
        }

        //Defining method to take an int and a boolean
        public static void WarningLevel(int warning, bool falseAlarm)
        {
            //if else statement with AND and OR operators 
            if (warning == 1 && falseAlarm == false)
            {
                Console.WriteLine("Warning Level is Low!");
            }
            else if (warning == 2 && falseAlarm == false)
            {
                Console.WriteLine("Warning Level is Medium!");
            }
            else if (warning == 3 && falseAlarm == false)
            {
                Console.WriteLine("Warning Level is High!");
            }
            else if (warning == 1 || falseAlarm == true)
            {
                Console.WriteLine("False Alarm");
            }
            else if (warning == 2 || falseAlarm == true)
            {
                Console.WriteLine("False Alarm");
            }
            else if (warning == 3 || falseAlarm == true)
            {
                Console.WriteLine("False Alarm");
            }
            else
            {
                Console.WriteLine("No Warning!");
            }
        }
    }
}
