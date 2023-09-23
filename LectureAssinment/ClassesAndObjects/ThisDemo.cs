using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
     class ThisDemo
    {
        static void Main(string[] args)
        {

        }
    }
    class Emp
    {
        int EmpId;
        string EmpName;
        double Salary;

        public Emp(int EmpId, string EmpName, double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
