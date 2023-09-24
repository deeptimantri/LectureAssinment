using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class InterfaceDemo
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.print();

            MyLib l = new MyLib();
            l.print();
        }
       
    }
    interface IPrintable
    {
        void print();
    }
    class MyClass : IPrintable 
    { 
       public void print()
        {
            Console.WriteLine("Print method from class MyClass");
        }
    }
    class MyLib :IPrintable
    {
        public void print()
        {
            Console.WriteLine("Print method from class MyLib");
        }
    }
}
