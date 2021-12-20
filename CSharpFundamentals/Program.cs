namespace CSharpFundamentals.Math
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.add(1, 2);
            Console.WriteLine(result);

        }
    }
}