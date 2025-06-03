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

        public int Width { get; set; }

        public string getSides()
        {
            return "#Sides is " + Sides;
        }

        public const int canvasWidth = 450;
        public const int canvasHeight =  450;

        public abstract void DisplaySidesAndArea();

        public abstract string getArea();
        public abstract string getSVG();

    }

    //Create derived class = square
    public class Square : Polygon
    {
        //constructor 
        public Square(int width)
        {
            Sides = 4;
            Width = width;
        }

        //class method to calculate area
        public override void DisplaySidesAndArea()
        {

            int area = Width * Width;
            Console.WriteLine("Square: " + base.getSides() + " and area is " + area);
        }

        public override string getArea()
        {
            int area = Width * Width;
            return area.ToString();
        }

        public override string getSVG()
        {
            return $"<svg width='{canvasWidth}' height='{canvasHeight}'>" +
                   $"<rect x='10' y='10' width='{Width}' height='{Width}' " +
                   $"style='fill:lightblue;stroke:black;stroke-width:2' />" +
                   $"</svg>";
        }
    }

    //Create derived class - rectangle
    public class Rectangle : Polygon
    {
        // Additional visual/style properties
        public int Height { get; set; }
        public string Description { get; set; }
        public string FillColour { get; set; }
        public string StrokeColour { get; set; }
        public int StrokeWidth { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
            FillColour = "lightcoral";
            StrokeColour = "black";
            StrokeWidth = 2;
            X = 10;
            Y = 10;
            Description = "";
            Sides = 4;
        }

        // Constructor including visual properties
        public Rectangle(int width, int height, string fillColour = "lightcoral", string strokeColour = "black",
                         int strokeWidth = 2, int x = 10, int y = 10, string description = "")
        {
            Width = width;
            Height = height;
            FillColour = fillColour;
            StrokeColour = strokeColour;
            StrokeWidth = strokeWidth;
            X = x;
            Y = y;
            Description = description;
            Sides = 4;
        }

        // Area and sides display logic
        public override void DisplaySidesAndArea()
        {
            int area = Width * Height;
            Console.WriteLine("Rectangle: " + base.getSides() + " and area is " + area);
        }

        public override string getArea()
        {
            int area = Width * Height;
            return area.ToString();
        }

        public override string getSVG()
        {
            return $"<svg width='{canvasWidth}' height='{canvasHeight}' style='border:1px dashed grey'>" +
                   $"<rect x='{X}' y='{Y}' width='{Width}' height='{Height}' " +
                   $"style='fill:{FillColour.ToLower()};stroke:{StrokeColour.ToLower()};stroke-width:{StrokeWidth}' />" +
                   $"</svg>";
        }
    }


    public class Triangle : Polygon
    {
        public int Height { get; set; }
        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;
            Sides = 3;
        }

        public override void DisplaySidesAndArea()
        {
            double area = 0.5 * Width * Height;
            Console.WriteLine("Triangle: " + base.getSides() + " and area is " + area);
        }

        public override string getArea()
        {
            double area = 0.5 * Width * Height;
            return area.ToString();
        }

        public override string getSVG()
        {
            int halfBase = Width / 2;
            return $"<svg width='{canvasWidth}' height='{canvasHeight}'>" +
                   $"<polygon points='{10},{Height + 10} {10 + Width},{Height + 10} {10 + halfBase},10' " +
                   $"style='fill:lightyellow;stroke:black;stroke-width:2' />" +
                   $"</svg>";
        }

    }

    public class Ellipse : Polygon
    {
        public int RadiusY { get; set; }

        public Ellipse(int radiusX, int radiusY)
        {
            Width = radiusX;
            RadiusY = radiusY;
            Sides = 0;
        }

        public override void DisplaySidesAndArea()
        {
            double area = Math.PI * Width * RadiusY;
            Console.WriteLine("Ellipse: " + base.getSides() + " and area is " + area);
        }

        public override string getArea()
        {
            double area = Math.PI * Width * RadiusY;
            return area.ToString();
        }

        public override string getSVG()
        {
            int cx = Width + 10;   // RadiusX + margin
            int cy = RadiusY + 10;  // RadiusY + margin

            return $"<svg width='{canvasWidth}' height='{canvasHeight}'>" +
                   $"<ellipse cx='{cx}' cy='{cy}' rx='{Width}' ry='{RadiusY}' " +
                   $"style='fill:lightgreen;stroke:black;stroke-width:2' />" +
                   $"</svg>";
        }

    }
}