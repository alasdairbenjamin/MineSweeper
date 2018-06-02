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
        private int _adjacentBombCount;

        public bool? ContainsBomb
        {
            get
            {
                if (!Clicked) return null;
                return _containsBomb;
            }
        }

        public int? AdjacentBombCount
        {
            get
            {
                if (!Clicked) return null;
                return _adjacentBombCount;
            }
        }

        public bool Clicked { get; private set; }

        public Tile(int adjacentBombCount, bool containsBomb)
        {
            _adjacentBombCount = adjacentBombCount;
            _containsBomb = containsBomb;
            Clicked = false;
        }

        public void OnClick()
        {
            Clicked = true;
        }
    }


}
