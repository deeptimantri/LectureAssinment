using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.LoopsProgram
{
    class DoWhileProg1
    {
        static void Main(string[] args)
        {
            // initial value
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10); // condition, must have semicolon ;

        }
    }
}
