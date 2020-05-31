using Metodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
       
    }
}
