using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment
{
     class IfElseDemo
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the value of A");
            a =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter the value of B");
            b = Convert.ToInt32(Console.ReadLine());

            
            if(a > b)
            {
                Console.WriteLine( "A is greater than B");
            }
            else if(b > a)
            {
                Console.WriteLine("B is greater than A");
            }
            else
            {
                Console.WriteLine("Both are same");
            }
        }
    }
}
