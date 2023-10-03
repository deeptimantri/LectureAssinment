using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayListDemo
{
     class ArrayListDemo1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30 };
            int[] arr2 = new int[8] ;
            ArrayList list = new ArrayList();

            list.Add(11);
            list.Add(33);
            list.Add(77);
            list.Add(9.20);
            list.Add("Hello");
            //Boxing ->Converting a value type in to ref type
            //unboxing -> converting a ref type data to value type
            //Non generic collection have performance issues due to implicit boxing unboxing 
            //so it is advisable to use non generic collection for small amount of data
            //With large data we should use generic as it does not perform boxing unboxing
            //Int value type -> Object ->Ref

            list.Insert(0, 1);
            list.Insert(2, 200);

            list.AddRange(arr);
            Console.WriteLine("=====================Before manupulation ==============");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //list.Remove("Hello");
            //list.RemoveAt(0);
            //list.RemoveRange(1, 3);

            //list.Sort();
            //list.Reverse();

            list.CopyTo(arr2);

            Console.WriteLine("=============arr2 ==============s");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            bool res = list.Contains(250);
            Console.WriteLine(res);

            Console.WriteLine("No of elements present in the collection " + list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
