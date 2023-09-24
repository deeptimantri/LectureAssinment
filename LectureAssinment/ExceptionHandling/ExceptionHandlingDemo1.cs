using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.ExceptionHandling
{
     class ExceptionHandlingDemo1
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[3];
                arr[0] = 0;
                arr[1] = 1;
                arr[2] = 2;
                arr[3] = 3;

                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}
