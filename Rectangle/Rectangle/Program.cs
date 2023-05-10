using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getArea()
        {
            return length * width;
        }

        public int getPerimeter()
        {
            return 2 *(length + width);
        }

        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Width: ");
            int width = int .Parse(Console.ReadLine());

            var rectangle = new Rectangle(length, width);
            Console.WriteLine($"Area: {rectangle.getArea()}");
            Console.WriteLine($"Perimeter: {rectangle.getPerimeter()}");
        }
    }
}
