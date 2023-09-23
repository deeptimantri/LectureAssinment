using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LectureAssinment.DataTypes_Demo
{
    class Data_Type_Demo2
    {
        static void Main(string[] args)
        {
            //The float data type can store fractional numbers from 3.4e−038 to 3.4e+038.It occupies 4 bytes in the memory.
            //Use f or F suffix with literal to make it float type.
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine(f1);//123456.5
            Console.WriteLine(f2);//1.123456

            //The double data type can store fractional numbers from 1.7e−308 to 1.7e+308.It occupies 8 bytes in the memory.
            //Use d or D suffix with literal to make it double type.
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine(d1);//12345678912345.5
            Console.WriteLine(d2);//1.123456789123456

            //The decimal data type can store fractional numbers from ±1.0 x 10 - 28 to ±7.9228 x 1028.
            //It occupies 16 bytes in the memory. 
            //Use m or M suffix with literal to make it decimal type.

            decimal dd1 = 123456789123456789123456789.5M;
            decimal dd2 = 1.1234567891345679123456789123m;

            Console.WriteLine(dd1);
            Console.WriteLine(dd2);
            //Use e or E to indicate the power of 10 as exponent part of scientific notation with float, double or decimal.
            //±The plus or minus sign is a mathematical symbol that indicates that a number may be more or less by a certain amount.
            //In other words, it indicates a choice of exactly two possible values,
            //one of which is obtained through addition and the other through subtraction.
        }
    }
}
