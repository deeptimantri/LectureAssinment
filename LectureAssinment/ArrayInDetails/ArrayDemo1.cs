using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class ArrayDemo1
    {
        static void Main(string[] args)
        {
            //various ways to declare an array
            int[] numArr = new int[10];
            numArr[0] = 1;
            numArr[1] = 2;
            numArr[2] = 3;
            numArr[3] = 4;
            numArr[4] = 5;
            numArr[5] = 6;
            numArr[6] = 7;
            numArr[7] = 8;
            numArr[8] = 9;
            numArr[9] = 10;

            int[] arr = { 1, 2, 3, 4, 5 };

            int[] arr2 = new int[] { 11,12,13,14,15};

            int[] arr3 = new int[2] { 10, 20 };

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
        }
        
    }
}
