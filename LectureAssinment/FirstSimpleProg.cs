
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace LectureAssinment//Namespace is a collection of corelated classes.
    //FCL is colletion of various namespaces namespaces which include predefined code which is provided by .net framework
{
    class FirstSimpleProg
    {
        static void Main(string[] args)
        {
            
            int a, b, addition;

            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());

            addition = a + b;
            Console.WriteLine("Addition = " + addition);
        }
    }
}
