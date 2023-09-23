using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.DataTypes_Demo
{
     class Data_Type_Demo3
    {
        static void Main(string[] args)
        {
            //In C#, a string is a series of characters that is used to represent text.
            //It can be a character, a word or a long passage surrounded with the double quotes ""
           
            string ch = "S";
            string word = "String";
            string text = "This is a string.";
            Console.WriteLine(ch);
            Console.WriteLine(word);
            Console.WriteLine(text);

            //Verbatim Strings
            //It is tedious to prefix \ to include every special characters.
            //Verbatim string in C# allows a special characters and line brakes. 
            //Verbatim string can be created by prefixing @ symbol before double quotes.
            string str = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = "test@test.com";

            Console.WriteLine(str);
            Console.WriteLine(path);
            Console.WriteLine(email);

            //String Interpolation
            //String interpolation is a better way of concatenating strings.
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

        }


    }
}
