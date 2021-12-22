using System;

namespace ArrayExample
{
    public class Program
    {
        static void Main(String[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1; 

            Console.WriteLine(numbers[0]); // intialized to 1 ,i.e numbers[0]=1
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];    
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[3]);

            var names = new string[3] { "John","James", "Mary" };




        }
    }
}