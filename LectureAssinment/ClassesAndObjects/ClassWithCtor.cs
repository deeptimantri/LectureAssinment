using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
    class ClassWithCtor
    {
        static void Main(string[] args)
        {
            employee e = new employee(1, "Deepika", 30000);
            Console.WriteLine(e);
        }
    }
    class employee
    {
        int EmpId;
        string EmpName;
        double Salary;

        public employee(int _EmpId, string _EmpName, double _Salary)
        {
            EmpId = _EmpId;
            EmpName = _EmpName;
            Salary = _Salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
