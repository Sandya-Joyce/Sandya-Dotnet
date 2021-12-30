using System;

namespace ArrayMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            //Length
            Console.WriteLine("Lenth:"+ numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:"+index);

            //Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers) 
            Console.WriteLine(n);

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Sort
            Array.Sort(another);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);



        }
    }
}