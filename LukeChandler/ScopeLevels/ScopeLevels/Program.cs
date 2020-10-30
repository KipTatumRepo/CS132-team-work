/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE04 Exercise 3
**Date: 2020-10-30
**Description: Playing around with Scope and its effect on variables."
*********/

using System;

namespace ScopeLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring 2 Variables at Class level
            int classAndMethodLevel = 24;
            int classAndBlockLevel = 48;

            //What they Output
            Console.WriteLine("Class Level: " + classAndMethodLevel);
            Console.WriteLine("Class Level: " + classAndBlockLevel);
            ShowLocalizedValues();
            Console.ReadKey();
        }

        //Making the method
        static void ShowLocalizedValues()
        {
            const bool ENTER_CONDITION = true;
            int classAndMethodLevel = 72;
            Console.WriteLine("Method Level: " + classAndMethodLevel);
            if (ENTER_CONDITION)
            {
                int classAndBlockLevel = 12;
                Console.WriteLine("Block Level: " + classAndBlockLevel);
            }

        }

    }

}
