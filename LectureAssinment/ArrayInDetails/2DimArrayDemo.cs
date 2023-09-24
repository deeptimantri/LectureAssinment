using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class _2DimArrayDemo
    {
        static void Main(string[] args)
        {
            // 2 D array  1. row 2. col

            int[,] arr = new int[3, 4];

            // OR
            // 3*4 = 12
            int[,] arr2 = new int[3, 4]
            {
                {1,2,3,4 },
                {11,22,33,44 },
                {100,200,300,400 }
            };


            Console.WriteLine(arr2[1, 0]);

            for (int i = 0; i < arr2.GetLength(0); i++) // GetLength(0) -> 0 row size
            {
                for (int j = 0; j < arr2.GetLength(1); j++) // 1 --> col size
                {
                    Console.Write($" arr2[{i},{j}]= {arr2[i, j]} ");
                }
                Console.WriteLine("\n");
            }

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            } 

        }
    }
}
