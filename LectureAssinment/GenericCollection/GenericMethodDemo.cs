using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
     class GenericMethodDemo
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine("x =" + x + " Y =" + y);

            float f1 = 3.5f, f2 = 4.5f;
            Swap(ref f1, ref f2);
            Console.WriteLine("f1 =" + f1 + " f2 =" + f2);
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
