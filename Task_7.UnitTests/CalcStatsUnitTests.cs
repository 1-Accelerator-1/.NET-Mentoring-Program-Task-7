using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_7.Services;
using Task_7.Services.Interfaces;

namespace Task_7.UnitTests
{
    [TestFixture]
    public class CalcStatsUnitTests
    {
        private ICalcStats _calcStats;

        [SetUp]
        public void Setup()
        {
            _calcStats = new CalcStats();
        }

        [Test]
        public async Task CalcCollectionStats_PassValidCollection_ShouldSetStats()
        {
            // Arrange
            var testCollection = new List<int> { 1, 2, 3, -5, 9, 0, 10 };

            // Act
            await _calcStats.CalcCollectionStats(testCollection);

            // Assert
            _calcStats.MaxNumber.Should().Be(10);
            _calcStats.MinNumber.Should().Be(-5);
            _calcStats.NumberOfElements.Should().Be(7);
            _calcStats.Average.Should().BeApproximately(2.857, 0.001);
        }

        [Test]
        public async Task CalcCollectionStats_PassNull_ShouldThrowArgumentNullException()
        {
            // Arrange
            List<int> testCollection = null;

            // Act
            Func<Task> testFunc = async () => await _calcStats.CalcCollectionStats(testCollection);

            // Assert
            await testFunc.Should().ThrowAsync<ArgumentNullException>();
        }
    }
}
