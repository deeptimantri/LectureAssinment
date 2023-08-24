using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment
{
     class DiffPreIncrePostIncre
    {
        static void Main(string[] args)
        {
            //PreIncrement Oprtator 
            //When we increase the value of a variable before assigning it to another variable then it is known as Pre-Increment
            int a = 5;
            int b = ++a;
            Console.WriteLine( "a = "+a);
            Console.WriteLine( "b = "+b);

            //PostIncrement Operator int a = 5;
            // When the value of a variable is incremented after assigning it to a variable, it is known as Post-Increment.
            int aa = 5;
            int bb = aa++;
            Console.WriteLine("aa = " + aa);
            Console.WriteLine("bb= " + bb);

            int j = 2, k = 2;
            Console.WriteLine(j-- - --j + ++k - k-- +(j-k)+ --j +j++ - --k + ++k);
        }
    }
}
