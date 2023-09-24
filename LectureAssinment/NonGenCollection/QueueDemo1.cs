using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayListDemo
{
    class QueueDemo1
    {
        static void Main(string[] args)
        {
            // Queue --> FIFO (first in first out)
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();//remove the first element- 10

            Console.WriteLine($"first element in the list {queue.Peek()}");
            Console.WriteLine($"total elements in the queue {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
