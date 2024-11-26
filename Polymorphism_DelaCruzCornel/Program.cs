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
                new Rectangle (10, 5),
                new Circle (7),
                new Triangle (5, 8),
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
        private double length;
        private double width;


        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width;}
            set { width = value; }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Circle : Shape
    {
        private double radius;
        
        public double Radius 
        {   get { return radius; }

            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Triangle : Shape
    {
        
        private double basetriangle;
        private double height;
        
        
        public double Base 
        {
            get { return basetriangle; }
            set { basetriangle = value; } 
        }

        public double Height 
        {
            get { return height; }
            set { height = value; } 
        }

        public Triangle (double basetriangle, double height)
        {
            Base = basetriangle;
            Height = height;
        }


        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
