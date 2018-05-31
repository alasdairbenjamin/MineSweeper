using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Tile
    {
        public bool ContainsBomb { get; set; }
        public bool Clicked { get; set; }
        public int AdjacentBombCount { get; set; }
    }
}
