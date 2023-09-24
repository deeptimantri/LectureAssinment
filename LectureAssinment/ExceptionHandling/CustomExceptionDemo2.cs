using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.ExceptionHandling
{
     class CustomExceptionDemo2
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            try
            {
                stud.AcceptDetails("Rohan", 19);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
    public class Student
    {
        private string name;
        private int age;
        public void AcceptDetails(string name, int age)
        {
            if (age < 18)
            {
                throw new AgeException("Your age is not valid");
            }
            else
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
