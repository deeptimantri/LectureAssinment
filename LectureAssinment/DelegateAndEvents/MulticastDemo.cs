using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.DelegateAndEvents
{
    public delegate int MyDelegate(int x, int y);
    class MulticastDemo
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            // c.Add --> added method reference
            MyDelegate myDelegate = new MyDelegate(c.Add); // added the ref of Add()
                                                           //+= add ref in the invocation list
            myDelegate += new MyDelegate(c.Sub);// adding another ref / adding ref for sub()
                                                // -= remove method ref from invocation list
                                                //myDelegate -= new MyDelegate(c.Sub);
            Delegate[] list = myDelegate.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45, 22));// call the methods from theinvocation list
            }
        }
    }
    public class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
