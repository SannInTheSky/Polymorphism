using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_DelaCruzCornel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle { Length = 10, Width = 5 },
                new Circle { Radius = 7 },
                new Triangle { Base = 5, Height = 8 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} Area: {shape.CalculateArea():F2}");
            }
            Console.ReadKey();
        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
