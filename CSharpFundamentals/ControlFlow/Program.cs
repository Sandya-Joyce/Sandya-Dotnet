using System;

namespace Iterations
{
  class Program
    {
        static void Main(String[] args)
        {
            for(var i=1;i <10;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for(var i=1;i>10;i--)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}