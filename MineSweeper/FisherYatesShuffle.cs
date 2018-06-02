using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public static class FisherYatesShuffle
    {
        public static int[] RandomSelection(IEnumerable<int> originalItems, int totalItemsToTake, int? seed = null)
        {
            var itemsCopy = originalItems.ToArray();

            var totalItems = itemsCopy.Length;
            if (totalItemsToTake > totalItems)
                throw new Exception("NumberOfItemsToTake must be less than the total number of originalItems.");

            var itemsToReturn = new int[totalItemsToTake];

            var itemsRemaining = totalItems;
            var itemsSelected = 0;

            var random = seed == null ? new Random() : new Random((int)seed);

            while(itemsSelected < totalItemsToTake)
            {
                var nextIndex = random.Next(itemsRemaining--);
                itemsToReturn[itemsSelected++] = itemsCopy[nextIndex];
                itemsCopy.Swap(nextIndex, itemsRemaining);
            }

            return itemsToReturn;
        }
    }
}
