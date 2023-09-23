using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.DataTypes_Demo
{
    class FloatingPoint
    {
        static void Main(string[] args)
        {
            //The float data type can store fractional numbers from 3.4e−038 to 3.4e+038. It occupies 4 bytes in the memory. 
            //Use f or F suffix with literal to make it float type.
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine(f1);//123456.5
            Console.WriteLine(f2);//1.123456

            //The double data type can store fractional numbers from 1.7e−308 to 1.7e+308
            double d1 = 12345678912345.5d;
            Console.WriteLine(d1);//12345678912345.5

            //The decimal data type can store fractional numbers from ±1.0 x 10-28 to ±7.9228 x 1028
            decimal dd1 = 123456789123456789123456789.5m;
            Console.WriteLine(dd1);

            //Use e or E to indicate the power of 10 as exponent part of scientific notation with float, double or decimal.
            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


        }
    }
}
