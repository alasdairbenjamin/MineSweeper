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
            var expectedIntTwo = intArray[indexTwo];

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
            var expectedStringTwo = stringArray[indexTwo];

            //Act
            stringArray.Swap(indexOne, indexTwo);

            //Assert
            Assert.AreEqual(expectedStringOne, stringArray[indexOne]);
            Assert.AreEqual(expectedStringTwo, stringArray[indexTwo]);
        }

        [Test]
        public void TestForEachWithSimpleActionOnIntegerList()
        {
            //Arrange
            const int intOne = 3;
            const int intTwo = 5;
            const int intThree = 7;
            var action = new Action<int>(x => x++);
            var intList = new List<int> { intOne, intTwo, intThree };
            var expectedResult = new List<int> { intOne + 1, intTwo + 1, intThree + 1 };

            //Act
            intList.ForEach(action);

            //Assert
            CollectionAssert.AreEqual(expectedResult, intList);

        }

        [Test]
        public void TestGetAdjacentPositionsWithCornerIndex()
        {
            //Assert
            var grid = new int[2,3];
            const int indexCornerOne = 0;
            const int indexCornerTwo = 2;
            const int indexCornerThree = 3;
            const int indexCornerFour = 5;
            
        }

        [Test]
        public void TestGetAdjacentPositionsWithEdgeIndex()
        {

        }

        [Test]
        public void TestGetAdjacentPositionsWithInternalIndex()
        {

        }
    }
}
