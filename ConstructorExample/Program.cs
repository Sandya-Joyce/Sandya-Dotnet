using System;

namespace MyConstructorExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Sandya");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}