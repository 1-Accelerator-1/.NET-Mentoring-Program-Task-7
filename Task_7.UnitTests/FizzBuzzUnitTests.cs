using FluentAssertions;
using NUnit.Framework;
using System;
using Task_7.Services;
using Task_7.Services.Interfaces;
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

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(27)]
        public void ConvertNumberToString_PassNumbersMultiplesOfOnlyThree_ShouldReturnTextFizz(int number)
        {
            // Act
            var stringNumber = _fizzBuzz.ConvertNumberToString(number);

            // Assert
            stringNumber.Should().NotBeNullOrEmpty();
            stringNumber.Should().BeEquivalentTo("Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50)]
        public void ConvertNumberToString_PassNumbersMultiplesOfOnlyFive_ShouldReturnTextBuzz(int number)
        {
            // Act
            var stringNumber = _fizzBuzz.ConvertNumberToString(number);

            // Assert
            stringNumber.Should().NotBeNullOrEmpty();
            stringNumber.Should().BeEquivalentTo("Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        public void ConvertNumberToString_PassNumbersMultiplesOfThreeAndFive_ShouldReturnTextFizzBuzz(int number)
        {
            // Act
            var stringNumber = _fizzBuzz.ConvertNumberToString(number);

            // Assert
            stringNumber.Should().NotBeNullOrEmpty();
            stringNumber.Should().BeEquivalentTo("FizzBuzz");
        }
    }
}