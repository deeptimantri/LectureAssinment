using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class StaticDemo
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Rohan");
            Student s2 = new Student("Suraj");
            // call the static method using class name
            Console.WriteLine(Student.GetCount());
            // instance methods
            Console.WriteLine(s1.PrintDetails());
            Console.WriteLine(s2.PrintDetails());

        }

    }
    public class Student
    {
        private int rollno;
        private string name;
        private static int count; // 0 --> class variable

        public Student(string name)
        {
            count++;
            this.rollno = count;
            this.name = name;
        }
        // class method --> call using class name
        public static int GetCount()
        {
            return count;
        }
        // instance (object) method --> call using object name 
        public string PrintDetails()
        {
            return $"Roll No {rollno}, Name={name}";
        }
    }

}
