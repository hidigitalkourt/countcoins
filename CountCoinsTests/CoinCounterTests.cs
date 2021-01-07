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

        [Fact]
        public void GivesBackNumberOfChangeOptionsWhenGivenPenniesAndNickels()
        {
            var input = new int[]{1, 5};
            var actual = 19;

            var expected = CoinCounter.GetTotalChangeOptions(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void GivesBackNumberOfChangeOptionsWhenGivenPenniesAndDimes()
        {
            var input = new int[]{1, 10};
            var actual = 9;

            var expected = CoinCounter.GetTotalChangeOptions(input);

            actual.Should().Be(expected);
        }

        [Fact]
        public void GivesBackNumberOfChangeOptionsWhenGivenPenniesAndQuarters()
        {
            var input = new int[]{1, 25};
            var actual = 3;

            var expected = CoinCounter.GetTotalChangeOptions(input);

            actual.Should().Be(expected);
        }
    }
}
