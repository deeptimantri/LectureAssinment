using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
     class StackDemo
    {
        static void Main(string[] args)
        {
            //Create and Add Elements in Stack
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("==================Display elements of a stack======================");
            foreach (var item in myStack)
                Console.WriteLine(item);

            Console.WriteLine("================Using Pop method ================================");
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
            myStack.Pop();

            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            Console.WriteLine("================Using peek method ================================");
            Console.WriteLine(myStack.Peek()); // 
           


            Console.WriteLine("=======================Adding array to stack==========================");
            //Adding array to stack
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack2 = new Stack<int>(arr);

            foreach (var item in myStack2)
                Console.WriteLine(item); //prints 4,3,2,1,
                                               //
            Console.WriteLine("Using Contains method returns ="+myStack2.Contains(3));
        }
    }
}
