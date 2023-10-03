using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class RefKeywordDemo
    {
        //the ref keyword indicates that an argument is passed by reference, not by value
       
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap( ref a, ref  b);
            Console.WriteLine($"a = {a} , b={b}");
        }
        static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}
