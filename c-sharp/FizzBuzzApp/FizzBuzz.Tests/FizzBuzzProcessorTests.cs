using FizzBuzzApp;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
	public class FizzBuzzProcessorTests
    {
		[Fact]
		public void Should_Return_1_When_1_is_entered()
		{
            FizzBuzzProcessor.Calculate(1).Should().Equals("1");
        }

        [Fact]
        public void Should_Return_2_When_2_is_entered()
        {
            FizzBuzzProcessor.Calculate(2).Should().Equals("2");
        }

        [Fact]
        public void Should_Return_4_When_4_is_entered()
        {
            FizzBuzzProcessor.Calculate(4).Should().Equals("4");
        }

        [Fact]
        public void Should_Return_Fizz_When_3_is_entered()
        {
            FizzBuzzProcessor.Calculate(3).Should().Equals("Fizz");
        }

        [Fact]
        public void Should_Return_Fizz_When_9_is_entered()
        {
            FizzBuzzProcessor.Calculate(9).Should().Equals("Fizz");
        }

        [Fact]
        public void Should_Return_Buzz_When_5_is_entered()
        {
            FizzBuzzProcessor.Calculate(5).Should().Equals("Buzz");
        }

        [Fact]
        public void Should_Return_Buzz_When_10_is_entered()
        {
            FizzBuzzProcessor.Calculate(10).Should().Equals("Buzz");
        }

        [Fact]
        public void Should_Return_FizzBuzz_When_15_is_entered()
        {
            FizzBuzzProcessor.Calculate(15).Should().Equals("FizzBuzz");
        }

        [Fact]
        public void Should_Return_FizzBuzz_When_30_is_entered()
        {
            FizzBuzzProcessor.Calculate(30).Should().Equals("FizzBuzz");
        }
    }
}
