using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.DataTypes_Demo
{
    class NumberDatatypeProg
    {
        static void Main(string[] args)
        {
            //The short data type is a signed integer that can store numbers from -32,768 to 32,767. It occupies 16-bit memory.
            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'
            ushort us1 = 65535;
            //ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("us1 =" + us1);

            //The int data type is 32-bit signed integer. It can store numbers from -2,147,483,648 to 2,147,483,647.
            int i = -2147483648;
            int j = 2147483647;
            //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("ui1 =" + ui1);
            //The long type is 64-bit signed integers. It can store numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;
            Console.WriteLine(l1);
            Console.WriteLine(l2);
        }
    }
}
