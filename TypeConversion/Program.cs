using System;

namespace TypeConversion
{
    class Program
    {
       static void Main(String[] args)
        {
            var number = "1234";
            var i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }

    }
}