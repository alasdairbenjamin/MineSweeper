using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public static class HelpersAndExtensions
    {
        public static int ConvertPositionToSingleIndex(Position pos, int totalCols)
        {
            return (pos.Row * totalCols + pos.Column);
        }

        public static Position ConvertSingleIndexToCoords(int combinedIndex, int totalCols)
        {
            return new Position(combinedIndex / totalCols, combinedIndex % totalCols);
        }

        public static List<Position> GetNeighbours(Position pos, int totalRows, int totalCols)
        {
            var rowIndex = pos.Row;
            var colIndex = pos.Column;
            var rowMultipliers = new List<int> { 0 };
            if (rowIndex != 0) rowMultipliers.Add(-1);
            if (rowIndex != totalRows - 1) rowMultipliers.Add(1);

            var colMultipliers = new List<int> { 0 };
            if (colIndex != 0) colMultipliers.Add(-1);
            if (colIndex != totalCols - 1) colMultipliers.Add(1);

            var modifiers = new HashSet<Position>();

            foreach (var rowMultiplier in rowMultipliers)
            {
                foreach (var colMultiplier in colMultipliers)
                    modifiers.Add(new Position(rowMultiplier, colMultiplier));
            }

            modifiers.Remove(default(Position));
            return modifiers.Select(m => pos + m).ToList();
        }

        public static void Swap<T>(this IList<T> array, int a, int b)
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
