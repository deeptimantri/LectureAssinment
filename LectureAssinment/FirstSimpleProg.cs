using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment
{
    class FirstSimpleProg
    {
        static void Main(string[] args)
        {
            int a, b, addition;

            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());

            addition = a + b;
            Console.WriteLine("Addition = " + addition);
        }
    }
}
