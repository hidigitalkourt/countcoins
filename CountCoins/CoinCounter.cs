using System;
using System.Collections.Generic;

namespace CountCoins
{
    public static class CoinCounter
    {
        public static int GetTotalChangeOptions(int[] coins)
        {
            var tally = new List<int>();
            if (coins.Length == 1)
            {
                tally.Add(1);
            }
            else
            {
                var maxCoinAmount = coins[1];
                var minRemainder = 100 - maxCoinAmount;
                for (var count = 0; count < minRemainder; count+=maxCoinAmount)
                {
                    tally.Add(1);
                }
            }
            return tally.Count;
        }
    }
}
