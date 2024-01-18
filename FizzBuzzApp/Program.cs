namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.GetFizzBuzz(i));
            }
        }
    }
}
