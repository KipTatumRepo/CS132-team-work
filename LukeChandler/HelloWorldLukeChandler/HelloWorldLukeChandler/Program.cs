using System;

/********
**
**Name: Chandler, Luke
**Class: CS 132
**Project: 01
**Date: 2020-10-11
**Description: Simple program to display Hello World. The output is 
**a console window that displays "Hello World~"
*********/

namespace HelloWorldLukeChandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "Hello World~ It is: ";
            Console.WriteLine(output + DateTime.Today);
            Console.ReadLine();
        }
    }
}
