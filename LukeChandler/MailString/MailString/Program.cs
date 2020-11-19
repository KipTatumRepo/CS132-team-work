/********
**Name: Chandler, Luke
**Class: CS132
**Project: Random PE06 Exercise 2
**Date: 11-14-2020
**Description: A program that takes in a first and last name and generates a specific email format
*********/

using System;

namespace MailString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the method GenerateEmailAddress
            Console.WriteLine("Name: Johnny Bravo");
            Console.WriteLine(GenerateEmailAddress("Johnny", "Bravo"));
            Console.WriteLine("Name: Luke Chandler");
            Console.WriteLine(GenerateEmailAddress("Luke", "Chandler"));
            Console.WriteLine("Name: LUKE CHANDLER");
            Console.WriteLine(GenerateEmailAddress("LUKE", "CHANDLER"));
            Console.ReadKey();
        }
        //Method to generated email, first letter of first name and first 3 of last name with @abc.com
        public static string GenerateEmailAddress(string firstName, string lastName)
        {
            //@abc.com email provider suffix
            string provider = "@abc.com";
            //final email address taht we will return
            string emailAddress;
            //getting the first letter of the first name in lowercase
            string firstInitial = firstName.Substring(0, 1).ToLower();
            //getting the first 3 letters of the last name in lowercase
            string firstThree = lastName.Substring(0, 3).ToLower();
            //Generate the email address
            emailAddress = firstInitial + firstThree + provider;
            //return the email address
            return emailAddress;
        }
    }
}
