using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeOutOfRangeForDouble
    {
        [Theory]
        [InlineData(1.0, 1.0, 1.0)]
        [InlineData(1.0, 1.0, 3.0)]
        [InlineData(2.0, 1.0, 3.0)]
        [InlineData(3.0, 1.0, 3.0)]
        public void DoesNothingGivenInRangeValue(double input, double rangeFrom, double rangeTo)
        {
            Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo);
        }

        [Theory]
        [InlineData(-1.0, 1.0, 3.0)]
        [InlineData(0.0, 1.0, 3.0)]
        [InlineData(4.0, 1.0, 3.0)]
        public void ThrowsGivenOutOfRangeValue(double input, double rangeFrom, double rangeTo)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(-1.0, 3.0, 1.0)]
        [InlineData(0.0, 3.0, 1.0)]
        [InlineData(4.0, 3.0, 1.0)]
        public void ThrowsGivenInvalidArgumentValue(double input, double rangeFrom, double rangeTo)
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [Theory]
        [InlineData(1.0, 0.0, 1.0, 1.0)]
        [InlineData(1.0, 0.0, 3.0, 1.0)]
        [InlineData(2.0, 1.0, 3.0, 2.0)]
        [InlineData(3.0, 3.0, 3.0, 3.0)]
        public void ReturnsExpectedValueGivenInRangeValue(double input, double rangeFrom, double rangeTo, double expected)
        {
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.MustBe.OutOfRange(input, "index", rangeFrom, rangeTo));
        }
    }
}
