using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Solid.Practice.Interfaces;
using Solid.Practice.Manager;
using Solid.Practice.Models;
using Solid.Practice.Repository;
using static System.Console;
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Responsability
            // var courseRepository = new CourseRepository();
            // courseRepository.AddEntry(new Course{ Name = "Patrones de diseño", Students= 1000, Rating = 5, StartDate = new DateTime(2021, 10, 02), Pay = 500.00 });
            // courseRepository.AddEntry(new Course { Name = "Flutter", Students = 1900, Rating = 4.5, StartDate = new DateTime(2021, 10, 10), Pay = 700.00 });

            // Console.WriteLine(courseRepository.ToString());
            // courseRepository.SaveToFile(@"Reports", "WorkReport.txt", courseRepository.ToString());

            // Open Closed Responsability
            // var areaCalculator = new AreaCalculator();
            // var shapes = new List<IShape>
            // {
            //     new Rectangle { Width = 40, Height = 20 },
            //     new Circle { Radius = 10 },
            //     new Triangule { Base = 12, Height = 15, Sides = new List<double> { 16.16, 16.16 } }
            // };
            // string result = areaCalculator.Area(shapes);
            // Console.WriteLine(result);
        }
    }
}