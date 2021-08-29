using System.Collections.Generic;
using System.Linq;
using Solid.Practice.Interfaces;

namespace Solid.Practice.Models
{
    public class Triangule : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public List<double> Sides { get; set; }
        public string Area()
        {
            string result = string.Empty;
            if (Sides.Count() <= 0)
                result = "No se puede realizar la operacion";
            if (Sides.Count() > 2)
                result = "Debe tener dos lados";
            double side = 0.0;
            foreach(var s in Sides)
                side += s;
            result = $"Triangulo: {(Base * Height) / 2}, Perimetro: {Base + side}";
            return result;
        }
    }
}