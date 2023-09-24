using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
     class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.WriteLine(id); //prints 1234

            Console.WriteLine("====================After removing ===========================");
            callerIds.Dequeue();
            foreach (var id in callerIds)
                Console.WriteLine(id);

            Console.WriteLine("========================Contains method ========================");
            Console.WriteLine( callerIds.Contains(2)); //true
            Console.WriteLine(  callerIds.Contains(10)); //false
        }
    }
}
