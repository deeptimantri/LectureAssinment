using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class OutKeywordDemo
    {
        //It is generally used when a method returns multiple values.
        static void Main(string[] args)
        {
            int a = 10, b = 20, sum, sub, m;
            calc(a, b, out sum, out sub, out m);

            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(m);



        }
        static void calc(int a, int b, out int sum, out int sub, out int m)
        {
            sum = a + b;
            sub = a - b;
            m = a * b;
        }

    }
}
