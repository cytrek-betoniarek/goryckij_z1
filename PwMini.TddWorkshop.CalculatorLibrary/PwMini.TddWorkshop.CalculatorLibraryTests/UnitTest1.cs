using PwMini.TddWorkshop.CalculatorLibrary;
using System;
using Xunit;

namespace PwMini.TddWorkshop.CalculatorLibraryTests
{
    public class UnitTest1
    {
        private readonly StringCalculator _calculator;

        public UnitTest1()
        {
            _calculator = new StringCalculator();
            //WhenSingleNumberProvided_ItShouldReturnThisNumber("wrwr", 6);
        }

        [Fact]
        public void Test1()
        {
            //Console.WriteLine("gitara");
        }

        [Theory]
        [InlineData("2", 2)]
        [InlineData("5", 2)]
        public void WhenSingleNumberProvided_ItShouldReturnThisNumber(string input, int expected)
        {
            Assert.True(int.Parse(input)==expected);
        }

        [Theory]
        [InlineData("2,2", 4)]
        public void CommaSeparator(string input, int expected)
        {
            Assert.True(_calculator.Add(input)==expected);
        }

        [Theory]
        [InlineData("2,2\n2", 6)]
        public void NewLineAndCommaSeparator(string input, int expected)
        {
            Assert.True(_calculator.Add(input) == expected);
        }

        [Theory]
        [InlineData(2, 2)]
        public void AddingVerification(int a, int b)
        {
            Assert.True(_calculator.MyAdd(a,b) == a+b);
        }

        [Theory]
        [InlineData("-1\n3", 2)]
        public void AddingNegative(string input, int expected)
        {
            if (input[0] == '-') throw new ArgumentOutOfRangeException();
            Assert.True(true);
        }
    }
}
