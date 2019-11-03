using System;
using System.Collections.Generic;

namespace Book.Core
{
    class Services
    {
        static void Main(string[] _)
        {
            var NewList = new List<double>() { 75.5, 85, 95, 90, 98 };

            var MathBook = new BookClass("Math");

            MathBook.AddGrade(NewList[0]);
            MathBook.AddGrade(NewList[1]);
            MathBook.AddGrade(NewList[2]);
            MathBook.AddGrade(NewList[3]);
            MathBook.AddGrade(NewList[4]);

            var Stats = MathBook.GetStatistics();

            Console.WriteLine($"The Average Result is: {Stats.Average:N2}");
            Console.WriteLine($"The lowest grade is: {Stats.Low}");
            Console.WriteLine($"The highest grade is: {Stats.High}");
        }
    }
}