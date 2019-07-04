using System;

namespace ShapeAreaLibrary
{
    public class Shape
    {
        private double area = 0;
        public double Area
        {
            get { return area; }
            private protected set { area = value; }
        }

        public double RecogniseAndGetArea(double r)
        {
            Circle circle = new Circle();
            circle.CalculateArea(r);
            Console.WriteLine($"Area of a given circle is {circle.Area}");
            return circle.Area;
        }
        public double RecogniseAndGetArea(double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            triangle.CalculateArea(a, b, c);
            Console.WriteLine($"Area of a given triangle is {triangle.Area}");
            return triangle.Area;
        }
        public bool GetRightTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            triangle.GetRight(a, b, c);
            Console.WriteLine($"Given triangle is right: {triangle.RightTriangle}");
            return triangle.RightTriangle;
        }
    }

    public class Circle : Shape
    {
        private double radius = 0;

        public double Radius
        {
            get { return radius; }
            private protected set { radius = value; }
        }

        public void CalculateArea(double radius)
        {
            Radius = radius;
            Area   = Math.PI * radius * radius;
        }
    }

    public class Triangle : Shape
    {
        private double[] side = new double[3] { 0, 0, 0 };

        private bool rightTriangle = false;

        public bool RightTriangle
        {
            get { return rightTriangle; }
            private protected set { rightTriangle = value; }
        }

        private double p = 0;

        public double[] Side
        {
            get { return side; }
            private protected set { side = value; }
        }

        public void CalculateArea(double a = 0, double b = 0, double c = 0)
        {
            side[0] = a;
            side[1] = b;
            side[2] = c;

            p    = (side[0] + side[1] + side[2]) / 2;

            Area = (double)Math.Pow(p * (p - side[0]) * (p - side[1]) * (p - side[2]), 0.5);
        }

        public void GetRight(double a = 0, double b = 0, double c = 0)
        {
            side[0] = a;
            side[1] = b;
            side[2] = c;

            if (Math.Pow(side[0], 2) == (Math.Pow(side[1], 2) + Math.Pow(side[2], 2)) ||
                Math.Pow(side[1], 2) == (Math.Pow(side[0], 2) + Math.Pow(side[2], 2)) ||
                Math.Pow(side[2], 2) == (Math.Pow(side[1], 2) + Math.Pow(side[0], 2)))
            {
                RightTriangle = true;
            }

        }
    }
}