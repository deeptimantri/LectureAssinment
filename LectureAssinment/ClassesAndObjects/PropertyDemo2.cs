using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
    class PropertyDemo2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 101;
            s1.name = "Student1";
            //s1.Marks = 100;//Property is read only


            Console.WriteLine("Student Id =" + s1.Id);
            Console.WriteLine("Student name =" + s1.Name);
            
        }
    }
    public class Student
    {
        public  int id;
        public string name;
        public int marks;

       
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Student Id can not be negative");
                }
                else
                {
                    id = value;
                }
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name can not be null or empty");
                }
                else
                {
                    Name = value;
                }
            }
            get
            {
                return string.IsNullOrEmpty(name) ? "No Name" : name;
            }
        }
        public int Marks
        {
            get
            {
                return Marks;
            }
        }
    }
}
