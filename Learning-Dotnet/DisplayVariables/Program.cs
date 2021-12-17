using System;

namespace DisplayVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //combination of both text and variable
            string name = "John";
            Console.WriteLine(name);

            //also use + character to add a varaible to another variable
            string firstName = "John";
            string lastName = "Doe";
            string fullName= firstName + lastName;
            Console.WriteLine(fullName);

            //Numeric values + works as mathematical operation (for integers)

            int x = 5;
            int y = 6;
            Console.WriteLine(x+y);

            // declare many variables
            int X = 5, Y = 6 , Z = 50;
            Console.WriteLine(X+Y+Z);


        }


    }
}
