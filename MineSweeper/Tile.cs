using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Tile
    {
        private bool _containsBomb;
        private uint _adjacentBombCount;

        public bool? ContainsBomb
        {
            get
            {
                if (!Clicked) return null;
                return _containsBomb;
            }
        }

        public uint Row { get; set; }

        public uint Col { get; set; }

        public uint? AdjacentBombCount
        {
            get
            {
                if (!Clicked) return null;
                return _adjacentBombCount;
            }
        }

        public bool Clicked { get; private set; }

        public Tile(uint row, uint col, uint adjacentBombCount, bool containsBomb)
        {
            Row = row;
            Col = col;
            _adjacentBombCount = adjacentBombCount;
            _containsBomb = containsBomb;
            Clicked = false;
        }

        public void IncrementAdjacentBombCount()
        {
            _adjacentBombCount++;
        }
    }


}
