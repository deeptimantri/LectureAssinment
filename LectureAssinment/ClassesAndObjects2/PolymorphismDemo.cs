using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager("Rohan", 28000, 3500);
            salesManager.CalculateSalary();
            Console.WriteLine(salesManager);// ToString() get called implicitly 

            Employee employee = new Employee("Suraj", 23000);
            employee.CalculateSalary();
            Console.WriteLine(employee);

            Employee employee2 = new Employee("Amol", 23000);
            employee2.CalculateSalary();
            Console.WriteLine(employee2.ToString());

            Employee e1 = employee;
            Console.WriteLine(employee.Equals(e1));
            Console.WriteLine(employee.GetHashCode());
            Console.WriteLine(e1.GetHashCode());

            // is a relationship
            Employee obj; // reference

            // run time binding / late binding / dynamic polymorphism
            obj = new SalesManager("Tushar", 33000, 3400);
            obj.CalculateSalary();// run --> obj is object of Salesmanager
            Console.WriteLine(obj);


        }
    }
    public class Employee
    {
        protected int id;
        protected string name;
        protected double bs, hra, ta, da, pf, gross;
        private static int count;
        public Employee(string name, double bs)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
        }
        // to allow method to be overriden we use virtual keyword
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da) - pf;
        }
        //public string PrintEmpSalary()
        //{
        //    return $"id={id}, name={name}, gross ={gross}";
        //}
        //ToString()  --> from base class object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }
    public class SalesManager : Employee
    {
        private double comm;
        // first always it calls to base class constructor
        // base keyword is used to call the base class members (constructor,method,protected members)

        public SalesManager(string name, double bs, double comm) : base(name, bs) //parametric constructor
        {
            this.comm = comm;

        }
        // method which is sam in base class should override the implementation
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da + comm) - pf;
        }
        // ToString() --> gives the string representation of an object
        public override string ToString()
        {
            return $"id={id}, name={name}, gross ={gross}";
        }
    }


}
