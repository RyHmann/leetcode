using System;
using System.Collections.Generic;

namespace CSharp.Solutions
{
    public class CandyCombinationCalculator
    {
        public static int DistributeCandies(int[] candyType)
        {
            var candyHashTable = new HashSet<int>(candyType);
            int numCandyTypes = candyHashTable.Count;
            int totalCandyCount = candyType.Length;
            int aliceLimit = totalCandyCount / 2;

            // alice can eat n/2 candies - get max number of different candies alice can eat
            if ( aliceLimit > numCandyTypes)
            {
                return numCandyTypes;
            }
            else
            {
                return aliceLimit;
            }
        }
    }
}