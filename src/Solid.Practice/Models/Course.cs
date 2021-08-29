using System;
using Solid.Practice.Utilities;

namespace Solid.Practice.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int Students { get; set; }
        public double Rating { get; set; }
        public DateTime StartDate { get; set; }
        public double Pay { get; set; }
    }
}