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
            else
            {
                var maxCoinAmount = coins[1];
                var minRemainder = 100 - maxCoinAmount;
                // var counted =

            }
            return changeOptions.Count;
        }
    }
}
