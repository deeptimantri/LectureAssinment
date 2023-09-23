using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LectureAssinment.SwitchDemo
{
    class SwitchCase1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A.English");
            Console.WriteLine("B.Hindi");
            Console.WriteLine("C.Marathi");

            Console.WriteLine("Select your option");
            char ch =Convert.ToChar( Console.ReadLine());

            switch (ch)
            {
                case 'A':
                    Console.WriteLine("You have selected English language");
                    break;
                case 'B':
                    Console.WriteLine("You have selected Hindi language");
                    break;
                case 'C':
                    Console.WriteLine("You have selected Marathi language");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

        }
    }
}
