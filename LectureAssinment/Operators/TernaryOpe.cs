using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LectureAssinment.Operators
{
    class TernaryOpe
    {
        static void Main(string[] args)
        {
            int a = 16;
            int b = 7;

            string result = a > b ? "A is greater than B" : "B is greater than A";
            //bool result = a > b ? true:false;
            //int res = a > b ? a : b;
            Console.WriteLine(result);

            //Even Odd using ternary Operator
            int number = 12;
            int res = 0;
            string ans = "";

            res = number % 2;
            ans = res == 0 ? "Even" : "Odd";
            Console.WriteLine("Number is =" + ans);
        }
    }
}
