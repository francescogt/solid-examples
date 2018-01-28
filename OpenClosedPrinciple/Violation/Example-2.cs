using SolidExamples.OpenClosedPrinciple.Solution;
using System;

namespace SolidExamples.OpenClosedPrinciple.Violation2
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
