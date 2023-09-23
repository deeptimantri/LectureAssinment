using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class StaticDemo1
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area1 = c1.CalculateArea();
            Console.WriteLine("Area of Circle = "+Area1);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area of Circle = " + Area2);
        }
    }
    class Circle
    {
        static float PI;
        int radius;

       static Circle()//Static constructor can be used to initialised ststic field.
        {
            PI = 3.14f;
        }

        public Circle(int _radius)
        {
           this.radius = _radius;
        }
        public float CalculateArea()
        {
            return PI * this.radius * this.radius;
        }
    }
}
