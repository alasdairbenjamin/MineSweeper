using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public static class HelpersAndExtensions
    {
        public static List<int> GetAdjacentPositions(int index, int totalRows, int totalCols)
        {
            var multipliers = new[] { -1, 0, 1 };
            var modifiers = new HashSet<int>();

            foreach (var rowMultiplier in multipliers)
            {
                foreach (var colMultiplier in multipliers)
                    modifiers.Add(rowMultiplier * totalCols + colMultiplier * totalRows);
            }

            modifiers.Remove(0);
            return modifiers.Select(m => index + m).Where(i => i >= 0 && i < totalRows * totalCols).ToList();
        }

        public static void ForEach<T>(this IEnumerable<T> ienum, Action<T> action)
        {
            foreach (var item in ienum)
                action(item);
        }
    }
}
