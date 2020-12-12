using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstNegativeOrZero
    {
        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1, "intPositive");
            Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1L, "longPositive");
            Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0M, "decimalPositive");
            Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0f, "floatPositive");
            Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0, "doublePositive");
        }

        [Fact]
        public void ThrowsGivenZeroIntValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(0, "intZero"));
        }

        [Fact]
        public void ThrowsGivenZeroLongValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(0L, "longZero"));
        }

        [Fact]
        public void ThrowsGivenZeroDecimalValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(0M, "decimalZero"));
        }

        [Fact]
        public void ThrowsGivenZeroFloatValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(0f, "floatZero"));
        }

        [Fact]
        public void ThrowsGivenZeroDoubleValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(0.0, "doubleZero"));
        }


        [Fact]
        public void ThrowsGivenNegativeIntValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-1, "intNegative"));
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-42, "intNegative"));
        }

        [Fact]
        public void ThrowsGivenNegativeLongValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-1L, "longNegative"));
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-456L, "longNegative"));
        }

        [Fact]
        public void ThrowsGivenNegativeDecimalValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-1M, "decimalNegative"));
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-567M, "decimalNegative"));
        }

        [Fact]
        public void ThrowsGivenNegativeFloatValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-1f, "floatNegative"));
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-4567f, "floatNegative"));
        }

        [Fact]
        public void ThrowsGivenNegativeDoubleValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-1.0, "doubleNegative"));
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NegativeOrZero(-456.453, "doubleNegative"));
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenPositiveValue()
        {
            Assert.Equal(1, Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1, "intPositive"));
            Assert.Equal(1L, Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1L, "longPositive"));
            Assert.Equal(1.0M, Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0M, "decimalPositive"));
            Assert.Equal(1.0f, Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0f, "floatPositive"));
            Assert.Equal(1.0, Cactus.Blade.Guard.Guard.Against.NegativeOrZero(1.0, "doublePositive"));
        }
    }
}
