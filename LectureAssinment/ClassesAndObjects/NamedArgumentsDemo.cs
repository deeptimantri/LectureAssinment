using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ClassesAndObjects
{
    class NamedArgumentsDemo
    {
        static void Main(string[] args)
        {
            // year parameter is optional to pass
            Date date1 = new Date(10, "June");

            // can be pass explicit value, value will be override
            Date date2 = new Date(1, "June", 2024);


            //named argument

             //Date date2 = new Date(month: "July", day: 1, year: 2023);

        }
    }
    public class Date
    {
        private int day, year;
        private string month;

        // default parameter --> year is a default parameter
        public Date(int day, string month, int year = 2023)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }
    }
}
    