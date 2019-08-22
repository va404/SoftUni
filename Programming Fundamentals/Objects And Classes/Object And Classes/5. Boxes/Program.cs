using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }
        public static double CalcDistance(Point first, Point second)
        {
            int deltaX = first.X - second.X;
            int deltaY = first.Y - second.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public int Width
        {
            get
            {
                return (int)Point.CalcDistance(UpperLeft, UpperRight);
            }
        }
        public int Height
        {
            get
            {
                return (int)Point.CalcDistance(UpperLeft, BottomLeft);
            }
        }
        public Box(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
        {
            this.UpperLeft = upperLeft;
            this.UpperRight = upperRight;
            this.BottomLeft = bottomLeft;
            this.BottomRight = bottomRight;
        }
        public static int CalcPerimeter(int width, int height)
        {
            return width * 2 + height * 2;
        }
        public static int CalcArea(int width, int height)
        {
            return width * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                List<Point> points = new List<Point>();

                foreach (var item in tokens)
                {
                    int[] pointCoord = item.Split(':').Select(int.Parse).ToArray();

                    points.Add(new Point(pointCoord[0], pointCoord[1]));
                }
                Box square = new Box(points[0], points[1], points[2], points[3]);

                Console.WriteLine($"Box: {square.Width}, {square.Height}");

                Console.WriteLine($"Perimeter: {Box.CalcPerimeter(square.Width, square.Height)}");

                Console.WriteLine($"Area: {Box.CalcArea(square.Width, square.Height)}");

                input = Console.ReadLine();
            }
        }
    }
}
