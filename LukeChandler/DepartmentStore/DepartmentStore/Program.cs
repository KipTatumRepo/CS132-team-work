/********
** Name: Chandler, Luke
** Class: CS132
** Project: PE09E02 
** Date: 2020-12-06
** Description: Display departments and corresponding promotions
*********/

using System;

namespace DepartmentStore
{
	class Program
	{
		static void Main(string[] args)
		{
			Fashion fashionDepartment = new Fashion();
			fashionDepartment.DisplayPromotions();
			Console.ReadLine();
		}
	}
		//Stores sale event data
		class Promotion
		{
			public string Name { get; private set; }
			public DateTime Start { get; private set; }
			public DateTime End { get; private set; }

			public Promotion(DateTime start, DateTime end, string name)
			{
				Start = start; End = end; Name = name;
			}
		}


		//Abstract class that stores and displays promotional information
		abstract class Department
		{
			public abstract string DepartmentName { get; protected set; }
			protected Promotion[] sales;
			protected abstract void AssignPromotions();

			public virtual void DisplayPromotions()
			{
				Console.WriteLine("{0} Department Promotions: ", DepartmentName);
				foreach (Promotion sale in sales)
				{
					Console.WriteLine("Name: " + sale.Name);
					Console.WriteLine("Start Date: " + sale.Start.ToString("m"));
					Console.WriteLine("End Date: " + sale.End.ToString("m"));
				}
			}
		}

		//Implementing class that sets department name and assigns promotions.
		class Fashion : Department
		{
			public override string DepartmentName { get; protected set; }
			public Fashion()
			{
				DepartmentName = "Fashion";
				AssignPromotions();
			}

			protected override void AssignPromotions()
			{
				DateTime start = new DateTime(2020, 12, 1);
				DateTime end = new DateTime(2020, 12, 15);
				Promotion promotion = new Promotion(start, end, "Winter Sale");

				sales = new Promotion[] { promotion };
			}
		}
}
