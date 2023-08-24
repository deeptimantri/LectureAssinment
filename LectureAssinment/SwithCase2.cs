using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment
{
     class SwithCase2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("101.English");
            Console.WriteLine("102.Hindi");
            Console.WriteLine("103.Marathi");

            Console.WriteLine("Select your option");
            int  ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 101:
                    Console.WriteLine("You have selected English language");
                    break;
                case 102:
                    Console.WriteLine("You have selected Hindi language");
                    break;
                case 103:
                    Console.WriteLine("You have selected Marathi language");
                    break;
                default:
                    break;
            }
        }
    }
}
