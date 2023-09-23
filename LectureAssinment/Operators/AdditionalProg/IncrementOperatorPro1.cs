using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Operators.AdditionalProg
{
    class IncrementOperatorPro1
    {
        static void Main(string[] args)
        {
            //If we use increment or decrement operator as an independent statement then we dont find any difference in the out put
            //where as if we use an increment and decrement operator as a part of an expression or a function call then we find difference in the output

            /*int a = 10;
            Console.WriteLine( "a = "+a);//Printing a's value
            a++;//perform 2 steps a= a;a = a+1
            Console.WriteLine( "a = "+a);
            Console.ReadKey();*/

            /*int a = 10;
            Console.WriteLine("a = " + a);//Printing a's value
            ++a;//perform 2 steps a= a+1;a =a
            Console.WriteLine("a = " + a);
            Console.ReadKey();*/

            /*int a = 10;
            Console.WriteLine("a = " + a);//Printing a's value
            a--;//perform 2 steps a =a;a= a-1
            Console.WriteLine("a = " + a);
            Console.ReadKey();*/

            int a = 10;
            Console.WriteLine("a = " + a);//Printing a's value
            --a;//perform 2 steps a= a-1;a=a
            Console.WriteLine("a = " + a);
            Console.ReadKey();

        }
    }
}
