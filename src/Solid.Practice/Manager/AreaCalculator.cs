using System;
using System.Collections.Generic;
using Solid.Practice.Interfaces;
using Solid.Practice.Models;

namespace Solid.Practice.Manager
{
    public class AreaCalculator
    {
        public string Area(List<IShape> shapes)
        {
            string area = "";
            foreach (var shape in shapes)
            {
                area += shape.Area();
                area += Environment.NewLine;
            }
            return area;
        }
    }
}