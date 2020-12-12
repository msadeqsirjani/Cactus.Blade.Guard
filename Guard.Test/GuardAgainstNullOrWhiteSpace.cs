using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstNullOrWhiteSpace
    {
        [Theory]
        [InlineData("a")]
        [InlineData("1")]
        [InlineData("some text")]
        [InlineData(" leading whitespace")]
        [InlineData("trailing whitespace ")]
        public void DoesNothingGivenNonEmptyStringValue(string nonEmptyString)
        {
            Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(nonEmptyString, "string");
            Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(nonEmptyString, "aNumericString");
        }

        [Fact]
        public void ThrowsGivenNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(null, "null"));
        }

        [Fact]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace("", "emptystring"));
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("   ")]
        public void ThrowsGivenWhiteSpaceString(string whiteSpaceString)
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(whiteSpaceString, "whitespacestring"));
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("1", "1")]
        [InlineData("some text", "some text")]
        [InlineData(" leading whitespace", " leading whitespace")]
        [InlineData("trailing whitespace ", "trailing whitespace ")]
        public void ReturnsExpectedValueGivenNonEmptyStringValue(string nonEmptyString, string expected)
        {
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(nonEmptyString, "string"));
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.Against.NullOrWhiteSpace(nonEmptyString, "aNumericString"));
        }
    }
}
