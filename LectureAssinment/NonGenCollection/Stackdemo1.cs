using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayListDemo
{
    class Stackdemo1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            // Push, Pop, Peek

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Pop(); //removes the top element in the collections

            Console.WriteLine($"Top element in the stack {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
