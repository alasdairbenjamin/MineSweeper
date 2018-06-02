using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Game
    {
        private int _bombs;
        private Tile[,] _grid;

        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Bombs { get; set; }

        public Game(int rows, int cols, int bombs)
        {
            Rows = rows;
            Columns = cols;
            Bombs = bombs;

            _grid = new Tile[rows, cols];
            for (var gridRow = 0; gridRow < rows; gridRow++)
            {
                for (var gridCol = 0; gridCol < cols; gridCol++)
                    _grid[gridRow, gridCol] = new Tile();
            }
        }

        public Tile this[int index]
        {
            get { return _grid[index / Columns, index % Rows]; }
            set { }
        }

        public Tile this[int rowIndex, int colIndex]
        {
            get { return _grid[rowIndex, colIndex]; }
            set { _grid[rowIndex, colIndex] = value; }
        }

        public void SetupGrid(int bombCount)
        {
            var gridPositions = new List<int>(_grid.Length);
            gridPositions = gridPositions.Select((cell, index) => index).ToList();

            var bombPositions = FisherYatesShuffle.RandomSelection(bombCount, gridPositions);

            for(var index = 0; index < _grid.Length; index++)
            {
                var neighbours = HelpersAndExtensions.GetAdjacentPositions(index, Rows, Columns);
                var adjacentBombCount = neighbours.Intersect(bombPositions).Count();
                this[index] = new Tile(adjacentBombCount, bombPositions.Contains(index));
            }
        }
    }
}
