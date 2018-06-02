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
    public class TestHelpersAndExtensions
    {
        [Test]
        public void TestSwapWithIntArray()
        {
            //Test with int array
            //Arrange
            const int indexOne = 0;
            const int indexTwo = 3;
            var intArray = new[] { 1, 2, 3, 4 };
            var expectedIntOne = intArray[indexTwo];
            var expectedIntTwo = intArray[indexOne];

            //Act
            intArray.Swap(indexOne, indexTwo);

            //Assert
            Assert.AreEqual(expectedIntOne, intArray[indexOne]);
            Assert.AreEqual(expectedIntTwo, intArray[indexTwo]);
        }

        [Test]
        public void TestSwapWithStringArray()
        { 
            //Test with string array
            //Arrange
            const int indexOne = 1;
            const int indexTwo = 2;
            var stringArray = new[] { "one", "two", "three"};
            var expectedStringOne = stringArray[indexTwo];
            var expectedStringTwo = stringArray[indexOne];

            //Act
            stringArray.Swap(indexOne, indexTwo);

            //Assert
            Assert.AreEqual(expectedStringOne, stringArray[indexOne]);
            Assert.AreEqual(expectedStringTwo, stringArray[indexTwo]);
        }

        [Test]
        public void TestGetAdjacentPositionsWithCornerIndex()
        {
            //Assert
            const int totalRows = 2;
            const int totalCols = 3;
            var grid = new int[totalRows, totalCols];
            var cornerOne = new Position(0, 0);
            var expectedCornerOneNeighbours = new[] { new Position(0, 1), new Position(1, 0), new Position(1, 1) };
            var cornerTwo = new Position(0, 2);
            var expectedCornerTwoNeighbours = new[] { new Position(0, 1), new Position(1, 2), new Position(1, 1) };
            var cornerThree = new Position(1, 0);
            var expectedCornerThreeNeighbours = new[] { new Position(0, 0), new Position(1, 1), new Position(0, 1) };
            var cornerFour = new Position(1, 2);
            var expectedCornerFourNeighbours = new[] { new Position(0, 2), new Position(1, 1), new Position(0, 1) };

            //Act
            var actualCornerOneNeighbours = HelpersAndExtensions.GetNeighbours(cornerOne, totalRows, totalCols);
            var actualCornerTwoNeighbours = HelpersAndExtensions.GetNeighbours(cornerTwo, totalRows, totalCols);
            var actualCornerThreeNeighbours = HelpersAndExtensions.GetNeighbours(cornerThree, totalRows, totalCols);
            var actualCornerFourNeighbours = HelpersAndExtensions.GetNeighbours(cornerFour, totalRows, totalCols);

            //Assert
            CollectionAssert.AreEquivalent(expectedCornerOneNeighbours, actualCornerOneNeighbours);
            CollectionAssert.AreEquivalent(expectedCornerTwoNeighbours, actualCornerTwoNeighbours);
            CollectionAssert.AreEquivalent(expectedCornerThreeNeighbours, actualCornerThreeNeighbours);
            CollectionAssert.AreEquivalent(expectedCornerFourNeighbours, actualCornerFourNeighbours);
        }

        [Test]
        public void TestGetAdjacentPositionsWithEdgeIndex()
        {
            //Assert
            const int totalRows = 3;
            const int totalCols = 4;
            var grid = new int[totalRows, totalCols];
            var topRow = new Position(0, 1);
            var expectedTopRowNeighbours = new[] 
                { new Position(0, 0), new Position(0, 2), new Position(1, 1), new Position(1, 0), new Position(1, 2) };
            var leftCol = new Position(1, 0);
            var expectedLeftColNeighbours = new[] 
                { new Position(0, 0), new Position(1, 1), new Position(2, 0), new Position(0, 1), new Position(2, 1) };
            var rightCol = new Position(1, 3);
            var expectedRightColNeighbours = new[] 
                { new Position(0, 3), new Position(2, 3), new Position(1, 2), new Position(0, 2), new Position(2, 2) };
            var bottomRow = new Position(2, 2);
            var expectedBottomRowNeighbours = new[] 
                { new Position(1, 2), new Position(2, 3), new Position(1, 3), new Position(1, 1), new Position(2, 1) };

            //Act
            var actualTopRowNeighbours = HelpersAndExtensions.GetNeighbours(topRow, totalRows, totalCols);
            var actualLeftColNeighbours = HelpersAndExtensions.GetNeighbours(leftCol, totalRows, totalCols);
            var actualRightColNeighbours = HelpersAndExtensions.GetNeighbours(rightCol, totalRows, totalCols);
            var actualBottomRowNeighbours = HelpersAndExtensions.GetNeighbours(bottomRow, totalRows, totalCols);

            //Assert
            CollectionAssert.AreEquivalent(expectedTopRowNeighbours, actualTopRowNeighbours);
            CollectionAssert.AreEquivalent(expectedLeftColNeighbours, actualLeftColNeighbours);
            CollectionAssert.AreEquivalent(expectedRightColNeighbours, actualRightColNeighbours);
            CollectionAssert.AreEquivalent(expectedBottomRowNeighbours, actualBottomRowNeighbours);
        }

        [Test]
        public void TestGetAdjacentPositionsWithInternalIndex()
        {
            //Assert
            const int totalRows = 4;
            const int totalCols = 3;
            var grid = new int[totalRows, totalCols];
            var centralPos = new Position(2, 1);
            var expectedNeighbours = new[]
            {
                new Position(1, 0), new Position(1, 1), new Position(1, 2), new Position(2, 0),
                new Position(2, 2), new Position(3, 0), new Position(3, 1), new Position(3, 2)
            };

            //Act
            var actualNeighbours = HelpersAndExtensions.GetNeighbours(centralPos, totalRows, totalCols);

            //Assert
            CollectionAssert.AreEquivalent(expectedNeighbours, actualNeighbours);
        }
    }
}
