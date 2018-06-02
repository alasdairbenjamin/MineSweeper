using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Game
    {
        private uint _bombs;

        public uint Rows { get; set; }
        public uint Columns { get; set; }
        public uint Bombs
        {
            get { return _bombs; }
            set
            {
                var maxBombs = Rows * Columns - 1;
                _bombs = (value > maxBombs ? maxBombs : value);
            }
        }

        public Tile[,] Grid { get; set; }

        public Game(uint rows, uint cols, uint bombs)
        {
            Rows = rows;
            Columns = cols;
            Bombs = bombs;

            Grid = new Tile[rows, cols];
            for (var gridRow = 0; gridRow < rows; gridRow++)
            {
                for (var gridCol = 0; gridCol < cols; gridCol++)
                    Grid[gridRow, gridCol] = new Tile();
            }
        }

        public Tile CreateTile(bool hasBomb)
        {

        }
    }
}
