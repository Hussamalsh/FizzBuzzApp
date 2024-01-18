using FizzBuzzApp;

namespace FizzBuzzAppTests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(1, "1")]
        public void GetFizzBuzz_ReturnsCorrectOutput(int number, string expected)
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetFizzBuzz(number);
            Assert.AreEqual(expected, result);
        }
    }
}
