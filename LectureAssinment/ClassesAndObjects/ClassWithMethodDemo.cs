using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
    class ClassWithMethodDemo
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.AcceptDetails();
            employee.Display();
        }
    }
    class Employee
    {
        int EmpId;
        string EmpName;
        double Salary;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter EmpId");
            EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EmpName");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Employee Id =" + EmpId);
            Console.WriteLine("Employee Name =" + EmpName);
            Console.WriteLine("Salary =" + Salary);
        }
    }
}
