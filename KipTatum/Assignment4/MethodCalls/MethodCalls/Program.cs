/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 04 
**Date: 2020-26-10
**Description: program will calculate and display an average grade value for a 
** student name G. Treele
*********/
using System;

namespace MethodCalls
{
	class Program
	{
		static void Main(string[] args)
		{
			//declare constant variables
			const float MATH_GRADE			= 80.0f;
			const float BIOLOGY_GRADE		= 80.0f;
			const float PROGRAMMING_GRADE	= 92.0f;
			const string STUDENT_NAME		= "G. Treele";

			//call method and assign the returned value to a variable
			float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);

			//display the student name and average score
			ShowAverage(STUDENT_NAME, average);
			Console.ReadKey();
		}
		//**Method Creation Section**//

		//take in three grades and return the calculated average of those three
		//grades
		static float CalculateAverage(float mg, float bg, float pg)
		{
			return (mg + bg + pg) / 3;
		}

		//take in the constant student name and calculated average grade so 
		//we can output the name and average grade in a defined format
		static void ShowAverage(string sn, float avg)
		{
			Console.WriteLine($"{sn}: {avg}");
		}
	}
}
