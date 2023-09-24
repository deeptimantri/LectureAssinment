using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            // 4 is the row size, [] --> col

            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 10, 20, 30, 40 };
            jaggedArray[2] = new int[] { 100, 200 };
            jaggedArray[3] = new int[] { 1000 };

            for (int i = 0; i < jaggedArray.Length; i++) // Length --> row size 4
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)// jaggedArray[i] --> col size in each row
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
