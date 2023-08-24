using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment
{
     class UnaryOperator2
    {
        static void Main(string[] args)
        {
            int a = 10, res;

            // post-increment example:
            // res is assigned 10 only,
            // a is not updated yet
            res = a++;

            //a becomes 11 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // post-decrement example:
            // res is assigned 11 only, a is not updated yet
            res = a--;

            //a becomes 10 now
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-increment example:
            // res is assigned 11 now since a
            // is updated here itself
            res = ++a;

            // a and res have same values = 11
            Console.WriteLine("a is {0} and res is {1}", a, res);


            // pre-decrement example:
            // res is assigned 10 only since
            // a is updated here itself
            res = --a;

            // a and res have same values = 10
            Console.WriteLine("a is {0} and res is {1}", a, res);
        }
    }
}
