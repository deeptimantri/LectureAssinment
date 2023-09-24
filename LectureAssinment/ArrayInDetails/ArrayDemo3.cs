using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class ArrayDemo3
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 78, 45, 12, 89, 23, 90, 11, 4, 8, 9 };
            int[] nos = new int[10];

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            // sort

            Array.Sort(numbers);
            Console.WriteLine("------after sort------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(numbers);
            Console.WriteLine("------after reverse------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Array.Copy(numbers, nos,10);
            Console.WriteLine("------------------");
            foreach (var item in nos)
            {
                Console.WriteLine(item);
            }

        }
    }
}
