/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE05 Exercise 4
**Date: 2020-11-06
**Description: While loop calling a method and asking for input whether to conitnue or quit the loop
*********/

using System;

namespace GoOrQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputReader = true;

            while (inputReader)
            {
                IsItDone();
                string doneYet = Console.ReadLine(); //asking for user input
                if (doneYet == "2") //Choose option that user is done and will exit from loop
                    break;
                else // keep going in the loop
                {
                    Console.WriteLine("You still have a ways to go.");
                    Console.WriteLine("");
                }
            }//Loop is finished
            Console.WriteLine("Go Home, you are DONE");
            Console.ReadLine();
        }

        public static void IsItDone()
        {
            //Find if the person is done
            Console.WriteLine("Complete the Task");
            Console.WriteLine("1. Keep Going. Not Done Yet");
            Console.WriteLine("2. You're Done. You can Stop");
        }
    }
}
