using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.ExceptionHandling
{
     class ExceptionHandlingDemo2
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter a number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a number");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;
                Console.WriteLine($"division is {c}");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in the Program. " + ex.Message); // Message is propertyfrom Exception class
            }
            
            finally
            {
                Console.WriteLine("End of the program");
            }
            
        }
    }

}
