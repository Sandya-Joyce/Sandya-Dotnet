using System;

namespace StringsDemo
{
    public class Program
    {
       static void Main(String[] args)
        {
            var firstName = "Sandya";
            var lastName = "Dasari";

            var fullName = firstName +" "+ lastName;    

            var myFullName = String.Format("My name is  {0},{1} ", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\n Look into the paths \\n folder1\\n folder2";
            Console.WriteLine(text);


              


        }
    }
}