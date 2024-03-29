﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.ExceptionHandling
{
     class CustomExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Some No");

                int n = Convert.ToInt32(Console.ReadLine());

                MyClass m = new MyClass();

                m.PropNo = n;

                Console.WriteLine(m.PropNo);
            }
            catch (NegativeException ne)
            {

                Console.WriteLine(ne.message);
            }
            finally {
            }
        }
    }
    public class NegativeException :Exception//1)Create your custom exception class which must be derived from Exception class
    {
        public string message;

        public NegativeException(string _message)
        {
            message = _message;
        }
    }
    class MyClass
    {
        int no;

        public int PropNo
        {
            get
            {
                return no;
            }
            set
            {
                if (value > 0)
                {
                    no = value;
                }
                else
                {
                    throw new NegativeException("no must be positive");//2)Use throw keyword to throw the exception
                }
            }
        }
    }
}
