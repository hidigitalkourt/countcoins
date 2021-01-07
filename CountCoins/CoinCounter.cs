using System;
using System.Collections.Generic;

namespace CountCoins
{
    public static class CoinCounter
    {
        public static int GetTotalChangeOptions(int[] coins)
        {
            var changeOptions = new List<int>();
            if (coins.Length == 1)
            {
                changeOptions.Add(coins[0]);
            }
            return changeOptions.Count;
        }
    }
}
