using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssignment.GenericCollection
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            // adding elements using add() method
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("================Prime Numbers =====================");
            Console.WriteLine("No of elelemts: " + primeNumbers.Count);
            foreach (int item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);
            Console.WriteLine("====================Cities=================");
            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of elelemts of big cities: " + bigCities.Count);

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            Console.WriteLine("No of elelemts of students: " + students.Count);
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Student Id = {Id} \t Student Name ={Name}";
        }
    }
}
