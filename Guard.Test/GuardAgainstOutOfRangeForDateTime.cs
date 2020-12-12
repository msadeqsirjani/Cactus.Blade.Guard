using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstOutOfRangeForDateTime
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 3)]
        [InlineData(-1, 1)]
        [InlineData(-1, 0)]
        public void DoesNothingGivenInRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            var input = DateTime.Now;
            var rangeFrom = input.AddSeconds(rangeFromOffset);
            var rangeTo = input.AddSeconds(rangeToOffset);
            Cactus.Blade.Guard.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo);
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(-4, -3)]
        public void ThrowsGivenOutOfRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            var input = DateTime.Now;
            var rangeFrom = input.AddSeconds(rangeFromOffset);
            var rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentOutOfRangeException>(() => Cactus.Blade.Guard.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(3, -1)]
        public void ThrowsGivenInvalidArgumentValue(int rangeFromOffset, int rangeToOffset)
        {
            var input = DateTime.Now;
            var rangeFrom = input.AddSeconds(rangeFromOffset);
            var rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.OutOfRange(DateTime.Now, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 3)]
        [InlineData(-1, 1)]
        [InlineData(-1, 0)]
        public void ReturnsExpectedValueGivenInRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            var input = DateTime.Now;
            var expected = input;
            var rangeFrom = input.AddSeconds(rangeFromOffset);
            var rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo));
        }
    }
}
