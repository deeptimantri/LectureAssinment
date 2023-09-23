using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class StaticClassDemo
    {
        static void Main(string[] args)
        {
           // MyCollege obj = new MyCollege();//Can not create instance of static class
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();
        }
    }
   static class MyCollege
    {
        //static fields
        public static string CollegeName;
        public static string Address;

        //static constructor
        static MyCollege()
        {
            CollegeName = "ABC College of Technology";
            Address = "Hyderabad";
        }
    }
   // class BC:MyCollege//Static class are by default sealed
    //{

    //}
}
