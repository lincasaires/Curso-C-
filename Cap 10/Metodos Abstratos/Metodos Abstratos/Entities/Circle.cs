using System;
using System.Collections.Generic;
using System.Text;
using Metodos_Abstratos.Entities.Enums;

namespace Metodos_Abstratos.Entities
{
    sealed class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius*Radius;
        }
    }
}
