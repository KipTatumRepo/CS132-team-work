/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE10E02 
**Date: 2020-12-08
**Description: Program that prints all of the colors in a list. Then subsitutes a color and checks if another is in the list
*********/

using System;
using System.Collections.Generic;

namespace ColorList
{
    class Program
    {
        //Method for printing values of the color list
        private static void Print(List<string> list)
        {
            foreach (string color in list)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //Adding colors to the list
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

            Print(Colors);

            //Size of the List
            int sizeOfList = Colors.Count;
            Console.WriteLine("The list of colors includes {0} colors", sizeOfList);

            //Sorting the List
            Colors.Sort();
            Console.WriteLine("\nThe colors sorted are");
            Print(Colors);

            //Getting index of and removing Violet and adding purple to penultimate index
            int violetIndex = Colors.IndexOf("Violet");
            Colors.RemoveAt(violetIndex);
            //Add Purple at the penultimate index
            Colors.Insert(violetIndex + 1, "Purple");
            Print(Colors);

            //check if there is Magenta
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list");
            }

            //Add Magenta and check again
            Colors.Add("Magenta");
            if (Colors.Contains("Magenta"))
            {
                Console.WriteLine("Magenta is in the list\n");
            }

            Print(Colors);


            //Magenta was added to the end of the list. Insert is needed if we have a specific index in mind that we want to add it to.
        }
    }
}
