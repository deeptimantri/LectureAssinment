using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
     class GenericClassDemo
    {
        static void Main(string[] args)
        {
            GenericsStackClass<int> gs = new GenericsStackClass<int>(2);

            gs.Push(1);
            gs.Push(2);
            gs.display();

            Console.WriteLine("after poping");

            int popElement = gs.Pop();
            Console.WriteLine("Element Pop From array =" + popElement);
        }
    }
    class GenericsStackClass<T>
    {
        int top, msize;
        T[] mArr;

        public GenericsStackClass(int size)
        {
            msize = size;
            top = -1;
            mArr = new T[msize];
        }
        public void Push(T element)
        {
            mArr[++top] = element;
        }
        public T Pop()
        {
            return mArr[top--];
        }
        public void display()
        {
            foreach (T item in mArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
