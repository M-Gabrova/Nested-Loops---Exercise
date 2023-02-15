using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();  

            string presentationName;
            int presentationCount = 0;
            double grade = 0;
            double studentGrade = 0;

            while (input != "Finish")
            {
                presentationName = input;
                grade = 0;

                for (int i = 1; i <= n; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                }
                grade = grade/n;
                Console.WriteLine($"{presentationName} - {grade:f2}.");
                studentGrade+= grade;
                presentationCount++;

                input= Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {studentGrade / presentationCount:f2}.");


        }
    }
}
