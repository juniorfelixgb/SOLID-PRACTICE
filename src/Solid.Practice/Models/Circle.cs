using System;
using Solid.Practice.Interfaces;

namespace Solid.Practice.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public string Area()
        {
            return $"Circulo: {Radius * Radius * Math.PI}";
        }
    }
}