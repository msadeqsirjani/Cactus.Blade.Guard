using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstZero
    {
        [Fact]
        public void DoesNothingGivenNonZeroValue()
        {
            Cactus.Blade.Guard.Guard.Against.Zero(-1, "minusOne");
            Cactus.Blade.Guard.Guard.Against.Zero(1, "plusOne");
            Cactus.Blade.Guard.Guard.Against.Zero(int.MinValue, "int.MinValue");
            Cactus.Blade.Guard.Guard.Against.Zero(int.MaxValue, "int.MaxValue");
            Cactus.Blade.Guard.Guard.Against.Zero(long.MinValue, "long.MinValue");
            Cactus.Blade.Guard.Guard.Against.Zero(long.MaxValue, "long.MaxValue");
            Cactus.Blade.Guard.Guard.Against.Zero(decimal.MinValue, "decimal.MinValue");
            Cactus.Blade.Guard.Guard.Against.Zero(decimal.MaxValue, "decimal.MaxValue");
            Cactus.Blade.Guard.Guard.Against.Zero(float.MinValue, "float.MinValue");
            Cactus.Blade.Guard.Guard.Against.Zero(float.MaxValue, "float.MaxValue");
            Cactus.Blade.Guard.Guard.Against.Zero(double.MinValue, "double.MinValue");
            Cactus.Blade.Guard.Guard.Against.Zero(double.MaxValue, "double.MaxValue");
        }

        [Fact]
        public void ThrowsGivenZeroValueIntZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(0, "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueLongZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(0L, "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDecimalZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(0.0M, "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueFloatZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(0.0f, "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDoubleZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(0.0, "zero"));
        }



        [Fact]
        public void ThrowsGivenZeroValueDefaultInt()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(default(int), "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultLong()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(default(long), "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultDecimal()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(default(decimal), "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultFloat()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(default(float), "zero"));
        }

        [Fact]
        public void ThrowsGivenZeroValueDefaultDouble()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(default(double), "zero"));
        }


        [Fact]
        public void ThrowsGivenZeroValueDecimalDotZero()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Zero(decimal.Zero, "zero"));
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenNonZeroValue()
        {
            Assert.Equal(-1, Cactus.Blade.Guard.Guard.Against.Zero(-1, "minusOne"));
            Assert.Equal(1, Cactus.Blade.Guard.Guard.Against.Zero(1, "plusOne"));
            Assert.Equal(int.MinValue, Cactus.Blade.Guard.Guard.Against.Zero(int.MinValue, "int.MinValue"));
            Assert.Equal(int.MaxValue, Cactus.Blade.Guard.Guard.Against.Zero(int.MaxValue, "int.MaxValue"));
            Assert.Equal(long.MinValue, Cactus.Blade.Guard.Guard.Against.Zero(long.MinValue, "long.MinValue"));
            Assert.Equal(long.MaxValue, Cactus.Blade.Guard.Guard.Against.Zero(long.MaxValue, "long.MaxValue"));
            Assert.Equal(decimal.MinValue, Cactus.Blade.Guard.Guard.Against.Zero(decimal.MinValue, "decimal.MinValue"));
            Assert.Equal(decimal.MaxValue, Cactus.Blade.Guard.Guard.Against.Zero(decimal.MaxValue, "decimal.MaxValue"));
            Assert.Equal(float.MinValue, Cactus.Blade.Guard.Guard.Against.Zero(float.MinValue, "float.MinValue"));
            Assert.Equal(float.MaxValue, Cactus.Blade.Guard.Guard.Against.Zero(float.MaxValue, "float.MaxValue"));
            Assert.Equal(double.MinValue, Cactus.Blade.Guard.Guard.Against.Zero(double.MinValue, "double.MinValue"));
            Assert.Equal(double.MaxValue, Cactus.Blade.Guard.Guard.Against.Zero(double.MaxValue, "double.MaxValue"));
        }
    }
}
