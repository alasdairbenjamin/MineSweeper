using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Game
    {
        private Tile[,] _grid;

        public int Rows { get; set; }
        public int Columns { get; set; }
        public int BombCount { get; set; }

        public Game(int rows, int cols, int bombs)
        {
            Rows = rows;
            Columns = cols;
            BombCount = bombs;

            _grid = new Tile[rows, cols];
            InitialiseGrid();
        }

        public Tile this[int rowIndex, int colIndex]
        {
            get { return _grid[rowIndex, colIndex]; }
            set { _grid[rowIndex, colIndex] = value; }
        }

        public Tile this[Position pos]
        {
            get { return _grid[pos.Row, pos.Column]; }
            set { _grid[pos.Row, pos.Column] = value; }
        }

        public void InitialiseGrid()
        {
            var gridPositions = new List<int>(_grid.Length);
            gridPositions = gridPositions.Select((cell, index) => index).ToList();

            var bombPositions = 
                FisherYatesShuffle.RandomSelection(gridPositions, BombCount)
                    .Select(HelpersAndExtensions.ConvertSingleIndexToCoords)
                        .ToList();

            for(var row = 0; row < _grid.GetLength(0); row++)
            {
                for(var col = 0; col < _grid.GetLength(1); col++)
                {
                    var position = new Position(row, col);
                    var neighbours = HelpersAndExtensions.GetNeighbours(position, Rows, Columns);
                    var adjacentBombCount = neighbours.Intersect(bombPositions).Count();
                    this[position] = new Tile(adjacentBombCount, bombPositions.Contains(position));
                }
            }
        }
    }
}
