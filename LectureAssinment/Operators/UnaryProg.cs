using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.Operators
{
    class UnaryProg
    {
        static void Main(string[] args)
        {
            int value1 = 56;
            Console.WriteLine("This is Example for Pre and Post Increment Operator");
            Console.WriteLine("Original Value: {0} ", value1); //print the original value.
            Console.WriteLine("Pre- Increment value: {0} ", ++value1); //First to print the value then increment operator perform.
            Console.WriteLine("Post-Increment Value: {0} ", value1++); // First to Increment the value then print the incremented value.
            Console.WriteLine("Original Value: {0} ", value1);
            Console.WriteLine("***************************************");
            Console.WriteLine("This is Example for Pre and Post Decrement Operator");
            Console.WriteLine("Original Value: {0} ", value1); //print the original value.
            Console.WriteLine("Pre-Decrement value: {0} ", --value1); //First to print the value then decrement operator perform.
            Console.WriteLine("Post-Decrement Value: {0} ", value1--); // First to decrement the value then print the decremented value.
            Console.WriteLine("Original Value: {0} ", value1);
            Console.ReadLine();
        }
    }
}
