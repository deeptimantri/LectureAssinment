using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects2
{
     partial class PartialClassDemo1
    {
       

    }
    public partial class Calc
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
    public partial class Empl
    {
        public Empl()
        {
            GenerateEmployeeId();
        }
        public int EmpId { get; set; }
        public string Name { get; set; }

        partial void GenerateEmployeeId();

    }

}
