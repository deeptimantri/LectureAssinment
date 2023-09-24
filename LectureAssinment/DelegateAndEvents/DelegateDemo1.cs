using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LectureAssignment.DelegateAndEvents.Calculation;

namespace LectureAssignment.DelegateAndEvents
{
     class DelegateDemo1
    {
        public delegate int MyDelegate(int x, int y);//1.Declare delegate
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            // c.Add --> added method reference
            MyDelegate myDelegate = new MyDelegate(c.Add);//Create instance of delegate
            Console.WriteLine(myDelegate.Invoke(20, 30));//invoke delegate
        }
    }
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
