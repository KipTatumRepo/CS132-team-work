/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 08 
**Date: 2020-23-11
**Description: program to display name, population and country of a city.  The program will also
** display which version of the program we are on.
*********/
using System;

namespace City
{
	class Program
	{
		
		static void Main(string[] args)
		{
			//Exercise 1
			Console.WriteLine("Exercise 1 display city and population via methods");
			City city = new City(); //instantiate a City object
			Console.WriteLine(city.GetCity()); //show name of the city for exercise 1
			Console.WriteLine(city.GetPopulation() + "\n"); //show the population of the city exercise 1

			//Exercise 2
			Console.WriteLine("Exercise 2 display city and population via methods but country by a public property");
			City cityEx2 = new City();
			Console.WriteLine(cityEx2.GetCity()); //show name of the city for exercise 1
			Console.WriteLine(cityEx2.GetPopulation()); //show the population of the city exercise 1
			Console.WriteLine(cityEx2.Country + "\n"); //show the country for exercise 2

			//Exercise 3
			City.Version();
			Console.ReadKey();

			
		}

		//City class with name and population assigned in the class
		class City
		{
			//private fields
			private string name;
			private int population;
			private string country;

			public string Country { get { return country; }} //Country property that is readonly because ther is no setter
			public City()
			{
				this.name = "Seattle";
				this.population = 1524879;
				this.country = "USA";
			}
			
			// return the name of the city
			public string GetCity()
			{
				return $"The name of the city is {name}";
			}

			//return the population of the city in proper format
			public string GetPopulation()
			{
				return $"The population of {name} is {population:n0}";
			}

			//Write the version of the program to the console when the method is called
			public static void Version()
			{
				Console.WriteLine("City Info Version 1.0");
			}
		}
	}
}
