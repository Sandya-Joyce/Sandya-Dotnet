using System;

namespace Operators
{
    class Program
    {
        static void Main(String[] args)
        {
            var a = 1;
            var b = 2;  
            var c = 3;
            //Arithematic Operators
            Console.WriteLine(a + b + c);
            Console.WriteLine(a + b * c);
            Console.WriteLine(!(a!=b));
            Console.WriteLine(a == b);

            //Logical Operators
            Console.WriteLine(c>b && c>a); // T and T = T
            Console.WriteLine(c>b && c==a); // T and F = F
            Console.WriteLine(c > b || c == a); // T or F = T



        }
    }

}