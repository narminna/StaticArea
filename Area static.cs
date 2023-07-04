using System;
namespace ConsoleApp
{

    public static class GeometryHelper
    {
        public static decimal AreaofRectangle(decimal length, decimal width)
        {
            decimal area = length*width;
            return area;
        }

        public static decimal AreaOfTriangle(decimal Base, decimal Height)
        {
            decimal area = 1/2*Base*Height;
            return area;
        }

        public static double AreaOfCircle(double Radius)
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            decimal rectangle = GeometryHelper.AreaofRectangle(7, 3);
            decimal triangle = GeometryHelper.AreaOfTriangle(4, 6);
            double circle = GeometryHelper.AreaOfCircle(15);

            Console.WriteLine("Area of Rectangle: " + rectangle);
            Console.WriteLine("Area of Triangle: " + triangle);
            Console.WriteLine("Area of Circle: " + circle);
        }
    }
}
