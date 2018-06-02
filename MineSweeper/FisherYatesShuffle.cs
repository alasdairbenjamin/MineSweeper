using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public static class FisherYatesShuffle
    {
        public static int[] RandomSelection(int totalItemsToTake, IEnumerable<int> originalItems)
        {
            var itemsCopy = originalItems.ToArray();

            var totalItems = itemsCopy.Length;
            if (totalItemsToTake > totalItems)
                throw new Exception("NumberOfItemsToTake must be less than the total number of originalItems.");

            var itemsToReturn = new int[totalItemsToTake];

            var itemsRemaining = totalItems;
            var itemsSelected = 0;

            var random = new Random();

            while(itemsSelected < totalItemsToTake)
            {
                var nextIndex = random.Next(itemsRemaining);
                itemsToReturn[itemsSelected++] = itemsCopy[random.Next(itemsRemaining--)];
                itemsCopy.Swap(nextIndex, itemsRemaining);
            }

            return itemsToReturn;
        }
    }
}
