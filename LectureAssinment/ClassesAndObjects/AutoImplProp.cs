using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
     class AutoImplProp
    {
        static void Main(string[] args)
        {
            EmployeeDet employee = new EmployeeDet();
            employee.Id = 101;
            employee.Age = 101;
            employee.Name = "Pranaya";
            employee.Address = "BBSR, Odisha, India";
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Address: {employee.Address}");
           
        }
    }
    public class EmployeeDet
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
