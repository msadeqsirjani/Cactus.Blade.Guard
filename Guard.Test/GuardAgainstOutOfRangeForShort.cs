using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeOutOfRangeForShort
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 1, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(3, 1, 3)]
        public void DoesNothingGivenInRangeValue(short input, short rangeFrom, short rangeTo)
        {
            Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo);
        }

        [Theory]
        [InlineData(-1, 1, 3)]
        [InlineData(0, 1, 3)]
        [InlineData(4, 1, 3)]
        public void ThrowsGivenOutOfRangeValue(short input, short rangeFrom, short rangeTo)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(-1, 3, 1)]
        [InlineData(0, 3, 1)]
        [InlineData(4, 3, 1)]
        public void ThrowsGivenInvalidArgumentValue(short input, short rangeFrom, short rangeTo)
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(1, 1, 1, 1)]
        [InlineData(1, 1, 3, 1)]
        [InlineData(2, 1, 3, 2)]
        [InlineData(3, 1, 3, 3)]
        public void ReturnsExpectedValueGivenInRangeValue(short input, short rangeFrom, short rangeTo, short expected)
        {
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }
    }
}
