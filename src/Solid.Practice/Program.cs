using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Solid.Practice.Models;
using Solid.Practice.Repository;
using static System.Console;
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single responsability
            var report = new CourseRepository();
            report.AddEntry(new Course{ Name = "Patrones de diseño", Students= 1000, Rating = 5, StartDate = new DateTime(2021, 10, 02), Pay = 500.00 });
            report.AddEntry(new Course { Name = "Flutter", Students = 1900, Rating = 4.5, StartDate = new DateTime(2021, 10, 10), Pay = 700.00 });

            Console.WriteLine(report.ToString());
            report.SaveToFile(@"Reports", "WorkReport.txt", report.ToString());
        }
    }
}