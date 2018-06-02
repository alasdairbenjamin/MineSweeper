using MineSweeper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperUnitTests
{
    [TestFixture]
    public class TestFisherYatesShuffle
    {
        [Test]
        public void TestRandomSelectionOfFisherYatesAlgorithm([Range(0, 10)] int seed)
        {
            //Arrange
            const int expectedSelectionCount = 3;
            var originalItems = new[] { 1, 2, 3, 4, 5 };

            //Act
            var selection = FisherYatesShuffle.RandomSelection(originalItems, expectedSelectionCount, seed);

            //Assert
            Assert.AreEqual(expectedSelectionCount, selection.Length, $"Failed with seed: {seed}");
            Assert.AreEqual(selection.Length, selection.Distinct().Count(), $"Failed with seed: {seed}");
            CollectionAssert.IsSubsetOf(selection, originalItems, $"Failed with seed: {seed}");
        }
    }
}
