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
    public class TestGame
    {
        [Test]
        public void TestCreateGameCapsBombCountToOneLessThanAllSquares()
        {
            //Arrange
            const int rows = 3;
            const int cols = 4;
            const int bombTotalInput = 15;
            var expectedBombCount = rows * cols - 1;

            //Act
            var game = new Game(rows, cols, bombTotalInput);

            //Assert
            Assert.AreNotEqual(bombTotalInput, game.Bombs);
            Assert.AreEqual(expectedBombCount, game.Bombs);
        }
    }
}
