using System;

namespace MyConstructorExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var orders = new Orders();
            customer.Orders.Add(orders);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}