using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.ThreadDemo
{
     class ThreadDemo1
    {
        static void Main(string[] args)
        {
            SampleThreadDemo obj = new SampleThreadDemo();
            // this is normal way of execution where M2() remains in wait state
            // until M1() completes its execution
            //obj.M1();
            //obj.M2();
            // using multithreading
            // unstarted state
            Thread t1 = new Thread(new ThreadStart(obj.M1));
            Thread t2 = new Thread(new ThreadStart(obj.M2));
            t1.Name = "First Thread"; // assign a name to thread
            t2.Name = "Second Thread";
            
            t1.Start();
           // t1.Join();// block the further thread execution,until the current completes the exe
            t1.Join(3000);//block the exe of further threads for 3 sec only
            t2.Start();

        }
    }
    public class SampleThreadDemo
    {
        public void M1()
        {
            Thread t1 = Thread.CurrentThread;// to read the thread name
            Console.WriteLine(t1.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void M2()
        {
            Thread t1 = Thread.CurrentThread;
            Console.WriteLine(t1.Name);
            for (int i = 10; i <= 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }

    }
