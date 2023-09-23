using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LectureAssinment.DataTypes_Demo
{
     class Data_Type_Demo1
    {
        static void Main(string[] args)
        {
            //Integer type numbers are positive or negative whole numbers without decimal points.
            //C# includes four data types for integer numbers: byte, short, int, and long.

            //The byte data type stores numbers from 0 to 255. It occupies 8-bit in the memory.
            byte b1 = 255;
            //byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'

            //The sbyte is the same as byte, but it can store negative numbers from -128 to 127.
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine(Byte.MaxValue);//255
            Console.WriteLine(Byte.MinValue);//0
            Console.WriteLine(SByte.MaxValue);//127
            Console.WriteLine(SByte.MinValue);//-128

            //The short data type is a signed integer that can store numbers from -32,768 to 32,767.
            //It occupies 16 - bit memory
            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            //The ushort data type is an unsigned integer. It can store only positive numbers from 0 to 65,535
            ushort us1 = 65535;
                                          
            //The int data type is 32-bit signed integer.
            //It can store numbers from -2,147,483,648 to 2,147,483,647
            int i = -2147483648;
            int j = 2147483647;
            //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            //The uint is 32-bit unsigned integer. It can store positive numbers from 0 to 4,294,967,295.
            //Optionally use U or u suffix after a number to assign it to uint variable.  
            uint ui1 = 4294967295;
            //uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            //The long type is 64 - bit signed integers.
            //It can store numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            //Use l or L suffix with number to assign it to long type variable.
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            //The ulong type stores positive numbers from 0 to 18,446,744,073,709,551,615.
            //If a number is suffixed by UL, Ul, uL, ul, LU, Lu, lU, or lu, its type is ulong.
            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;


            //Every data type has a default valueNumeric type is 0, boolean has false, and char has '\0' as default value
            //int i = default; // 0
            //float f = default;// 0
            //decimal d = default;// 0
            //bool b = default;// false
            //char c = default;// '\0'

        }
    }
}
