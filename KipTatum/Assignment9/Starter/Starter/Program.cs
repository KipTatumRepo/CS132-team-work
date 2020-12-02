/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 09 
**Date: 2020-11-30
**Description: This program will display the fall sale of the fashion departments start and 
** end date
*********/
using System;

namespace Starter
{
	class Program
	{
		//a promotion has a name, start and end date
		class Promotion
		{
			public string Name { get; private set; }
			public DateTime Start { get; private set; }
			public DateTime End { get; private set; }

			//The constructor forces the entry of start and end dates, along with a promotion name
			public Promotion(DateTime start, DateTime end, string name)
			{
				Start = start;
				End = end;
				Name = name;
			}
		}


		//all classes will use this base class, each class will have different implentations
		//of the members so it is abstract
		abstract class Department
		{
			public abstract string DepartmentName { get; set; } //all departments need a name
			protected Promotion[] sales; //there can be multiple sales in a department

			//all classes need to assign promotions in some form
			protected abstract void AssignPromotions();

			//this is the preferred way to diplay promotions, however it can be customized per class
			//if necessary
			public virtual void DisplayPromotions()
			{
				Console.WriteLine($"{DepartmentName} Department Promotions: ");
				foreach (Promotion sale in sales)
				{
					Console.WriteLine("Name:        {0}", sale.Name);
					Console.WriteLine("Start Date:  {0}", sale.Start.ToString("m"));
					Console.WriteLine("End Date:    {0}", sale.End.ToString("m"));
				}
			}
		}

		class Fashion : Department
		{
			public override string DepartmentName { get; set; }

			//This class will always have the name Fashion so we assign it in the constructor
			public Fashion()
			{
				DepartmentName = "Fashion";
				AssignPromotions();
			}

			//the fashion class only needs to show start and end dates and the name of the promotion
			protected override void AssignPromotions()
			{
				DateTime start = new DateTime(2020, 9, 1);
				DateTime end = new DateTime(2020, 9, 15);
				Promotion promo = new Promotion(start, end, "Fall Sale");

				sales = new Promotion[] { promo };
			}
		}

		static void Main(string[] args)
		{
			Fashion fashionDepartment = new Fashion();
			fashionDepartment.DisplayPromotions();
			Console.ReadKey();
		}
	}	
}

