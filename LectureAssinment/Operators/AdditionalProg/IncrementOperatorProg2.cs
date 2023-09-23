using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Operators.AdditionalProg
{
    class IncrementOperatorProg2
    {
        static void Main(string[] args)
        {
            //int a, b = 1;

            /*1)
            a = b++;//a= b;b++

            Console.WriteLine($"a ={a},b={b}");*/
            /*2)
            a = b++ + ++b;//a= b(a=1)|b++(b=2)|++b(b=3)|a=b(a=1+3(4))//a =4 b= 3
            Console.WriteLine($"a ={a},b={b}");*/
            /*3)
            a = ++b + ++b;//b incre = 2|a=b(a= 2)|b incre(b=3)|a= b(a= 2+3(5))//a = 5 b= 3
            Console.WriteLine($"a ={a},b={b}");
            a = ++b + b++ + ++b;//b incre b=2|a=b(a=2)|a= b(a= 2)|b++(b=3)|b incre(b=4)|a= b(2+2+4)//a=8 b=4*/

            int i = 11;

            i = i++ + ++i;//i=i(i=11)|i++(i=12)|++i(i=13)|i=i(i=12+12(24)//i = 24
            Console.WriteLine("i =" + i);

            int a = 11, b = 22, c;

            c = a + b + a++ + b++ + ++a + ++b;//11+22+12+23+12+23
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);


        }
    }
}
