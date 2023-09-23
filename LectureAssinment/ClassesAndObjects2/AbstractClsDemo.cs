using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class AbstractClsDemo
    {
        static void Main(string[] args)
        {
            circle c = new circle(5);
            c.CalculateArea();

            Square s = new Square(8);
            s.CalculateArea();
        }
    }

    abstract class Shape
    {
        public abstract void CalculateArea();
    }
    class circle : Shape 
    {
        int radius;

        public circle(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine($"Area of a circle={area}");
        }
    }
    class Square : Shape 
    {
        int side;

        public Square(int side)
        {
            this.side = side;
        }
        public override void CalculateArea()
        {
            double area = 4 * side;
            Console.WriteLine($"Area of a square ={area}");
        }
    }
}
