using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
    
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            HR hr = new HR(101, "Emp1", 3000, 500);
            hr.display();

            MarketingExe Me = new MarketingExe(202, "Emp2", 4000, 500);
            Me.display();
        }
    }
    class employee
    {
        int EmpId;
        string EmpName;
        double Salary;

        public employee(int EmpId,string EmpName,double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.Salary = Salary;

        }
        public virtual void display()
        {
            Console.WriteLine($"Employee Id ={EmpId} \t Employee Name = {EmpName} \t Salary = {Salary}");
        }
    }
    class HR:employee
    {
        int DA;

        public HR(int EmpId,string EmpName,double Salary,int DA):base(EmpId,EmpName,Salary)
        {
                this.DA = DA;
        }
        public override void display()
        {
            base.display();//reusability
            Console.WriteLine($"Dearness allowance is {this.DA}");//Extensibility
        } 
    }
    class MarketingExe:employee
    {
        int Commission;
        public MarketingExe(int EmpId,string EmpName,double Salary,int Commission): base(EmpId,EmpName,Salary)
        {
            this.Commission = Commission;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine($"Commission ={Commission}");
        }
    }
}
