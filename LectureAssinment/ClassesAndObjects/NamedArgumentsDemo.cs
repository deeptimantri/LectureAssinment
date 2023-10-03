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

            Console.WriteLine("Date 1 ="+ date1);

            // can be pass explicit value, value will be override
            Date date2 = new Date(1, "June", 2024);

            Console.WriteLine("Date 2 ="+ date2);
            //named argument

            Date date3 = new Date(month: "July", day: 1, year: 2023);
            Console.WriteLine("Date 3 ="+ date3);


        }
    }
    public class Date
    {
        int day, year;
        string month;

        public Date()//default constructor
        {
                
        }
        // default parameter --> year is a default parameter
        public Date(int day, string month, int year = 2023)
        {
            this.day = day;
            this.year = year;
            this.month = month;
        }
        public override string ToString()
        {
            return $"Day = {day} / Month = {month} /Year = {year}";
        }
    }
}
    