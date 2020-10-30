/********
**Name: Chandler, Luke
**Class: CS 132
**Project: PE04 Exercise 1
**Date: 2020-10-30
**Description: Calling methods to display a student grade average and name"
*********/

using System;

namespace MethodCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the Constants
            const float MATH_GRADE = 80.0f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = "G. Treele";

            //Calling the CalculateAverage method
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);

            //Displaying the Result
            ShowAverage(STUDENT_NAME, average);
            Console.ReadKey();
        }

        //Creating the CalculateAverage method to average the Math, Biology, and Programming grades
        static float CalculateAverage(float mathGrade, float biologyGrade, float programmingGrade)
        {
            return (mathGrade + biologyGrade + programmingGrade) / 3;
        }

        //Creating the ShowAverage Method to display the sudents name and average in "G. Treele average: 84" format
        static void ShowAverage(string studentName, float gradeAverage)
        {
            Console.WriteLine($"{studentName} average: {gradeAverage}");
        }
    }
}
