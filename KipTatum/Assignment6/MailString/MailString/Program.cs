/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 06 
**Date: 2020-09-11
**Description: program to create an email address from a given users first and last name
*********/
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MailString
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CreateEmail("Kip", "Tatum"));
			Console.WriteLine(CreateEmail("ALL", "CAPS"));
			Console.WriteLine(CreateEmail("todos", "lower"));
			Console.ReadKey();
		}

		//This method will create an email address that consists of the first letter of a first name and the last
		//3 letters of a last name
		public static string CreateEmail(string firstname, string lastname)
		{
			string email; //declare variable to return
			string domain = "@abc.com"; //add this domain to the end of the manipulated string
			string firstLetter = firstname.Substring(0, 1).ToLower(); //grab the first letter of the first name and convert to lowercase
			string threeLast = lastname.Substring(0, 3).ToLower(); //grab the first three letters of the last name and covert to lowercase
			email = firstLetter + threeLast + domain; //concatenate the 3 strings
			Console.WriteLine($"{firstname} {lastname}'s new email address is:"); //let the user know who's email address we created
			return email;
		}
	}
}
