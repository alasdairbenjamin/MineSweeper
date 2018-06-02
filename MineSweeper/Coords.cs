using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public struct Coords
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator== (Coords coordsOne, Coords coordsTwo)
        {
            return coordsOne.x == coordsTwo.x && coordsOne.y == coordsTwo.y;
        }

        public static bool operator!= (Coords coordsOne, Coords coordsTwo)
        {
            return !(coordsOne == coordsTwo);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coords)) return false;
            var coords = (Coords)obj;
            return x == coords.x && y == coords.y;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
    }
}
