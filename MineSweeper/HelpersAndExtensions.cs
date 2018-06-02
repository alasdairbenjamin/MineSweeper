using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public static class HelpersAndExtensions
    {
        public static int ConvertCoordsToSingleIndex(int row, int col, int totalCols)
        {
            return (row * totalCols + col);
        }

        public static Tuple<int, int> ConvertSingleIndexToCoords(int combinedIndex, int totalCols)
        {
            return Tuple.Create(combinedIndex / totalCols, combinedIndex % totalCols);
        }

        public static List<Coords> GetAdjacentPositions2D(int rowIndex, int colIndex, int totalRows, int totalCols)
        {
            var rowMultipliers = new List<int> { 0 };
            if (rowIndex != 0) rowMultipliers.Add(-1);
            if (rowIndex != totalRows) rowMultipliers.Add(1);

            var colMultipliers = new List<int> { 0 };
            if (colIndex != 0) colMultipliers.Add(-1);
            if (colIndex != totalRows) colMultipliers.Add(1);

            var modifiers = new HashSet<Coords>();

            foreach (var rowMultiplier in rowMultipliers)
            {
                foreach (var colMultiplier in colMultipliers)
                    modifiers.Add(rowMultiplier * totalCols + colMultiplier * totalRows);
            }

            modifiers.Remove(0);
            return modifiers.Select(m => index + m).Where(i => i >= 0 && i < totalRows * totalCols).ToList();
        }

        public static void ForEach<T>(this IEnumerable<T> iEnum, Action<T> action)
        {
            foreach (var item in iEnum)
                action(item);
        }

        public static void Swap<T>(this IList<T> array, int a, int b)
        {
            var temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
