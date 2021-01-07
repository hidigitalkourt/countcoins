using System;
using CountCoins;
using FluentAssertions;
using Xunit;

namespace CountCoinsTests
{
    public class CoinCounterTests
    {
        [Fact]
        public void GivesBackNumberOfChangeOptionsWhenGivenPennies()
        {
            var input = new int[]{1};
            var actual = 1;

            var expected = CoinCounter.GetTotalChangeOptions(input);

            actual.Should().Be(expected);
        }
    }
}
