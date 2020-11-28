/********
**Name: Chandler, Luke
**Class: CS132
**Project: PE08 Exercises 1,2,3 
**Date: 2020-11-27
**Description: A program that displays name, population, country, and version
*********/

using System;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
			//For the first exercise, intantiate a new City object with name and population
			City city = new City();
			Console.WriteLine(city.GetCity());
			Console.WriteLine(city.GetPopulation());
			Console.WriteLine("\n");

			//For the second exercise, intatiate a new City object with name, population, and country
			City city2 = new City();
			Console.WriteLine(city2.GetCity());
			Console.WriteLine(city2.GetPopulation());
			Console.WriteLine(city2.Country);
			Console.WriteLine("\n");

			//For the third exercise, display the version number
			City.VersionNumber();

			Console.ReadKey();

        }
    }

	class City
	{
		//fields for the constructor for the City
		private string name;
		private int population;
		private string country;

		//Country is a read only field and is not to be modified. I.e. Let's just return Korea everytime
		public string Country { get { return ("The country is ") + country; } }

		public City()
		{
			this.name = "Seoul";
			this.population = 13000000;
			this.country = "South Korea";
		}

		//Get the name of the City
		public string GetCity()
		{
			return $"{name} is the City";
		}

		//Get the population of the City
		public string GetPopulation()
		{
			return $"With a population of {population}";
		}

		//Display 'City Info Version 1.0' in a static method
		public static void VersionNumber()
		{
			Console.WriteLine("City Info Version 1.0");
		}
	}
}
