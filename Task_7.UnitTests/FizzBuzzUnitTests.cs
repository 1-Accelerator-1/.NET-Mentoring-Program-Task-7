using FluentAssertions;
using NUnit.Framework;
using System;
using Task_7.ValidationExceptions;

namespace Task_7.UnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        private IFizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(13)]
        public void ConvertNumberToString_PassNumberFrom1To100WithoutNumbersMultiplesOfThreeAndFive_ShouldReturnStringNumber(int number)
        {
            // Act
            var stringNumber = _fizzBuzz.ConvertNumberToString(number);

            // Assert
            stringNumber.Should().NotBeNullOrEmpty();
            stringNumber.Should().BeEquivalentTo(number.ToString());
        }

        [TestCase(0)]
        [TestCase(-15)]
        [TestCase(110)]
        public void ConvertNumberToString_PassNumberGreaterThenHundredOrLessThenOne_ShouldThrowException(int number)
        {
            // Act
            Func<string> testFunc = () => _fizzBuzz.ConvertNumberToString(number);

            // Assert
            testFunc.Should().Throw<NumberOutOfRangeException>().WithMessage("The number out of range (1 - 100).");
        }
    }
}