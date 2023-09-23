using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class OverloadingDemo
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            int Ans1 =c.Addition(10, 20);
            int Ans2 = c.Addition(10, 20, 30);
            double Ans3 = c.Addition(10.22, 20.4);

            Console.WriteLine(Ans1);
            Console.WriteLine(Ans2);
            Console.WriteLine(Ans3);
        }
    }
    public class Calculation
    {
        // method overloading
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Addition(double a, double b)
        {
            return a + b;
        }
    }

}
