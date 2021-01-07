using System;
using CountCoins;
using FluentAssertions;
using Xunit;

namespace CountCoinsTests
{
    public class CoinCounterTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(25)]
        public void GivesBackNumberOfChangeOptionsWhenGivenAllSameCoins(int coinAmount)
        {
            var input = new int[]{coinAmount};
            var actual = 1;

            var expected = CoinCounter.GetTotalChangeOptions(input);

            actual.Should().Be(expected);
        }
    }
}
