using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Operators
{
    class LogiOperators
    {
        static void Main(string[] args)
        {
            bool a = true, b = false, result;

            // AND operator
            result = a && b;
            Console.WriteLine("AND Operator: " + result);

            // OR operator
            result = a || b;
            Console.WriteLine("OR Operator: " + result);

            // NOT operator
            result = !a;
            Console.WriteLine("NOT Operator: " + result);
        }
    }
}
