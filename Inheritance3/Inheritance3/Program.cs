using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class RegularPolygon
    {
        public void calculatePerimeter(int length, int sides)
        {
            int result = length * sides;
            Console.WriteLine($"Perimeter: {result}");
        }
    }

    class Square : RegularPolygon { 
        public int length = 200;
        public int sides = 4;
        public void calculateArea()
        {
            int area = length * length;
            Console.WriteLine($"Area of square = {area}");
        }
    }

    class Rectangle : RegularPolygon
    {
        public int length = 100;
        public int breadth = 200;
        public int sides = 4;
        public void calculateArea()
        {
            int area = length * breadth;
            Console.WriteLine($"Area of rectangle = {area}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            s1.calculateArea();
            s1.calculatePerimeter(s1.length, s1.sides);

            Rectangle r1 = new Rectangle();
            r1.calculateArea();
            r1.calculatePerimeter(r1.length, r1.sides);
        }
    }
}
