using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class ArrayDemo2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            //write data  to array
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine($"Enter the element of an array =");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //read data from array
            Console.WriteLine("=============Using for loop=============================");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("=============Using foreach ===============================");

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
