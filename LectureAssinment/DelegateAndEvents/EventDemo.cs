using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.DelegateAndEvents
{
    public delegate void DelegateHandler();
    class EventDemo
    {
        static void FailMessage()
        {
            Console.WriteLine("OOps ! You are fail");
        }
        static void PassMessage()
        {
            Console.WriteLine("Great ! You are Pass with good score");
        }
        static void Main(string[] args)
        {
            Student stud = new Student();
            // bind event with delegate
            stud.Fail += new DelegateHandler(FailMessage);
            stud.Pass += new DelegateHandler(PassMessage);
            stud.AcceptScore(33);
        }

    }
    public class Student
    {
        // declaration of event
        public event DelegateHandler Fail;
        public event DelegateHandler Pass;
        public void AcceptScore(int score)
        {
            if (score < 40)
            {
                // raise an event
                Fail();
            }
            else
            {
                Pass();
            }
        }
    }

}
