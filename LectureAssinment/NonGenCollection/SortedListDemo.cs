using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.NonGenCollection
{
     class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(3, "Item1");
            list.Add(1, "Item2");
            list.Add(4, "Item3");
            list.Add(5, "Item4");
            list.Add(2, "Item5");

            list.Remove(3); // remove element using key
            list.RemoveAt(0); //sorted list maintain the indexing
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }
    }
}
