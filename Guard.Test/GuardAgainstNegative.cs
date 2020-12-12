using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstNegative
    {
        [Fact]
        public void DoesNothingGivenZeroValue()
        {
            Cactus.Blade.Guard.Guard.Against.Negative(0, "intZero");
            Cactus.Blade.Guard.Guard.Against.Negative(0L, "longZero");
            Cactus.Blade.Guard.Guard.Against.Negative(0.0M, "decimalZero");
            Cactus.Blade.Guard.Guard.Against.Negative(0.0f, "floatZero");
            Cactus.Blade.Guard.Guard.Against.Negative(0.0, "doubleZero");
        }

        [Fact]
        public void DoesNothingGivenPositiveValue()
        {
            Cactus.Blade.Guard.Guard.Against.Negative(1, "intZero");
            Cactus.Blade.Guard.Guard.Against.Negative(1L, "longZero");
            Cactus.Blade.Guard.Guard.Against.Negative(1.0M, "decimalZero");
            Cactus.Blade.Guard.Guard.Against.Negative(1.0f, "floatZero");
            Cactus.Blade.Guard.Guard.Against.Negative(1.0, "doubleZero");
        }

        [Fact]
        public void ThrowsGivenNegativeIntValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Negative(-1, "negative"));
        }

        [Fact]
        public void ThrowsGivenNegativeLongValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Negative(-1L, "negative"));
        }

        [Fact]
        public void ThrowsGivenNegativeDecimalValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Negative(-1.0M, "negative"));
        }

        [Fact]
        public void ThrowsGivenNegativeFloatValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Negative(-1.0f, "negative"));
        }

        [Fact]
        public void ThrowsGivenNegativeDoubleValue()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Negative(-1.0, "negative"));
        }

        [Fact]
        public void ReturnsExpectedValueGivenNonNegativeIntValue()
        {
            Assert.Equal(0, Cactus.Blade.Guard.Guard.Against.Negative(0, "intZero"));
            Assert.Equal(1, Cactus.Blade.Guard.Guard.Against.Negative(1, "intOne"));
        }

        [Fact]
        public void ReturnsExpectedValueGivenNonNegativeLongValue()
        {
            Assert.Equal(0L, Cactus.Blade.Guard.Guard.Against.Negative(0L, "longZero"));
            Assert.Equal(1L, Cactus.Blade.Guard.Guard.Against.Negative(1L, "longOne"));
        }

        [Fact]
        public void ReturnsExpectedValueGivenNonNegativeDecimalValue()
        {
            Assert.Equal(0.0M, Cactus.Blade.Guard.Guard.Against.Negative(0.0M, "decimalZero"));
            Assert.Equal(1.0M, Cactus.Blade.Guard.Guard.Against.Negative(1.0M, "decimalOne"));
        }

        [Fact]
        public void ReturnsExpectedValueGivenNonNegativeFloatValue()
        {
            Assert.Equal(0.0f, Cactus.Blade.Guard.Guard.Against.Negative(0.0f, "floatZero"));
            Assert.Equal(1.0f, Cactus.Blade.Guard.Guard.Against.Negative(1.0f, "floatOne"));
        }

        [Fact]
        public void ReturnsExpectedValueGivenNonNegativeDoubleValue()
        {
            Assert.Equal(0.0, Cactus.Blade.Guard.Guard.Against.Negative(0.0, "doubleZero"));
            Assert.Equal(1.0, Cactus.Blade.Guard.Guard.Against.Negative(1.0, "doubleOne"));
        }
    }
}
