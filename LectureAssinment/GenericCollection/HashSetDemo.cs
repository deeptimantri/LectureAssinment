using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("Pune");
            set1.Add("Mumbai");
            set1.Add("nashik");
            set1.Add("Pune");
            set1.Remove("nashil");// remove specific value
            set1.Clear(); // remove all values
            foreach (string item in set1)
            {
                Console.WriteLine(item);

            }
            // Math operations using HashSet 1.UnionWith 2. IntersectWith 3. ExceptWith
            HashSet<string> course1 = new HashSet<string>();
            course1.Add("C");
            course1.Add("C++");
            course1.Add("C#");
            course1.Add("Java");
            course1.Add("Ruby");

            HashSet<string> course2 = new HashSet<string>();
            course2.Add("Php");
            course2.Add("C++");
            course2.Add("Perl");
            course2.Add("Java");

            //course1.UnionWith(course2);
            //foreach (string s in course1)
            //{
            // Console.WriteLine(s);
            //}
            //course1.IntersectWith(course2);
            //foreach (string s in course1)
            //{
            // Console.WriteLine(s);
            //}
            course2.ExceptWith(course1);
            foreach (string s in course2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
