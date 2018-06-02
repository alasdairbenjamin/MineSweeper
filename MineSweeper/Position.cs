namespace MineSweeper
{
    public struct Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }

        public static bool operator== (Position posOne, Position posTwo)
        {
            return posOne.Row == posTwo.Row && posOne.Column == posTwo.Column;
        }

        public static bool operator!= (Position posOne, Position posTwo)
        {
            return !(posOne == posTwo);
        }

        public static Position operator+ (Position posOne, Position posTwo)
        {
            return new Position(posOne.Row + posTwo.Row, posOne.Column + posTwo.Column);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position)) return false;
            var coords = (Position)obj;
            return Row == coords.Row && Column == coords.Column;
        }

        public override int GetHashCode()
        {
            return Row.GetHashCode() ^ Column.GetHashCode();
        }
    }
}
