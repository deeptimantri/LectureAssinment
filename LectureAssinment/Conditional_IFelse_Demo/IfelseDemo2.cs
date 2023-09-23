using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Conditional_IFelse_Demo
{
    class IfelseDemo2
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 2 no ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a is greather");
            }
            else if (a < b)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("Both are equals");
            }

        }
    }
}
