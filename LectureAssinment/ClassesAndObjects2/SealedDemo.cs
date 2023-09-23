using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class SealedDemo
    {
        static void Main(string[] args)
        {

        }
    }
    class A
    {
        public virtual void X()
        {
            Console.WriteLine("Method x from class A");
        }
        public virtual void Y()
        {
            Console.WriteLine("Method Y from class A");
        }
    }
    sealed class B : A
    {
        sealed public override void X()
        {
            Console.WriteLine("Method x from class B");
        }
        public override void Y()
        {
            Console.WriteLine("Method Y from class B");
        }
    }
    //class C : B
    //{
    //    public override void X()
    //    {
    //        base.X();
    //    }
    //    public override void Y()
    //    {
    //        Console.WriteLine("Method Y from class C");
    //    }
    //}
   
}
