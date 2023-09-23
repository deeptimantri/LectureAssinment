using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Operators
{
    class AssignOperators
    {
        static void Main(string[] args)
        {
            // initialize variable x
            // using Simple Assignment
            // Operator "="
            int x = 15;

            // it means x = x + 10
            x += 10;
            Console.WriteLine("Add Assignment Operator: " + x);

            // initialize variable x again
            x = 20;

            // it means x = x - 5
            x -= 5;
            Console.WriteLine("Subtract Assignment Operator: " + x);

            // initialize variable x again
            x = 15;

            // it means x = x * 5
            x *= 5;
            Console.WriteLine("Multiply Assignment Operator: " + x);

            // initialize variable x again
            x = 25;

            // it means x = x / 5
            x /= 5;
            Console.WriteLine("Division Assignment Operator: " + x);

            // initialize variable x again
            x = 25;

            // it means x = x % 5
            x %= 5;
            Console.WriteLine("Modulo Assignment Operator: " + x);

        }
    }
}
