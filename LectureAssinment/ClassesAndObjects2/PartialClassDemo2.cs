using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class PartialClassDemo2
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Addition(1, 1));
            Console.WriteLine(calc.Multiply(4, 4));


            var emp = new Empl();
            Console.WriteLine(emp.EmpId); // prints genereted ids

        }

    }
    public partial class Calc
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    public partial class Empl
    {
        partial void GenerateEmployeeId()
        {
            this.EmpId = 1;
        }
    }

}
