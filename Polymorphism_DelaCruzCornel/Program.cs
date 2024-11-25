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
            Rectangle rectangle = new Rectangle { Length = 10, Width = 5 };
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            Circle circle = new Circle { Radius = 7 };
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
