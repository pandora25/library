using System;
using System.Collections.Generic;
using System.Text;

namespace Book.Core
{
    public class BookClass
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public BookClass(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        //Compute the Stats.
        public Statistics GetStatistics()
        {
            var Stats = new Statistics
            {
                Average = 0.0,
                Low = double.MaxValue,
                High = double.MinValue
            };

            foreach (var grade in Grades)
            {
                Stats.Low = Math.Min(grade, Stats.Low);
                Stats.High = Math.Max(grade, Stats.High);
                Stats.Average += grade;
            }
            Stats.Average /= Grades.Count;
            return Stats;
        }
    }
}