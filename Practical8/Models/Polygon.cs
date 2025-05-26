using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical8.Models
{
    public abstract class Polygon
    {
        private int sides;
        public int Sides
        {
            get { return sides; }
            set { sides = value; }
        }

        public int Length { get; set; }

        public string getSides()
        {
            return "#Sides is " + Sides;
        }

        public abstract void DisplaySidesAndArea();


    }

    //Create derived class = square
    public class Square : Polygon
    {
        //constructor 
        public Square(int length)
        {
            Sides = 4;
            Length = length;
        }

        //class method to calculate area
        public override void DisplaySidesAndArea()
        {

            int area = Length * Length;
            Console.WriteLine("Square: " + base.getSides() + " and area is " + area);
        }
    }

    //Create derived class - rectangle
    public class Rectangle : Polygon
    {
        //member specific to rectangle
        public int Breadth { get; set; }

        //constructor
        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
            Sides = 4;
        }

        //class method to calculate area
        public override void DisplaySidesAndArea()
        {

            int area = Length * Breadth;
            Console.WriteLine("Rectangle: " + base.getSides() + " and area is " + area);
        }
    }

    public class Triangle : Polygon
    {
        public int Height { get; set; }
        public Triangle(int length, int height)
        {
            Length = length;
            Height = height;
            Sides = 3;
        }

        public override void DisplaySidesAndArea()
        {
            double area = 0.5 * Length * Height;
            Console.WriteLine("Triangle: " + base.getSides() + " and area is " + area);
        }
    }

    public class Ellipse : Polygon
    {
        public int RadiusY { get; set; }

        public Ellipse(int radiusX, int radiusY)
        {
            Length = radiusX;
            RadiusY = radiusY;
            Sides = 0;
        }

        public override void DisplaySidesAndArea()
        {
            double area = Math.PI * Length * RadiusY;
            Console.WriteLine("Ellipse: " + base.getSides() + " and area is " + area);
        }
    }
}