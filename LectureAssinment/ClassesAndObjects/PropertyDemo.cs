using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
    class PropertyDemo
    {
        static void Main(string[] args)
        {

            student c1 = new student();
            c1.SetId(10);
            Console.WriteLine($"Student Id = {c1.GetId()}");

        }
    }

    public class student
    {
        public int id;
        public string name;
        public int marks;

        public void SetId(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("Student Id can not be negative");
            }
            else
            {
                this.id = id;
            }
        }
        public int GetId()
        {
            return id;
        }
    }
}
