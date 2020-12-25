using Cactus.Blade.Guard;
using System;
using System.Linq;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeNullOrEmpty
    {
        [Fact]
        public void DoesNothingGivenNonEmptyStringValue()
        {
            Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty("a", "string");
            Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty("1", "aNumericString");
        }

        [Fact]
        public void DoesNothingGivenNonEmptyGuidValue()
        {
            Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(Guid.NewGuid(), "guid");
        }

        [Fact]
        public void DoesNothingGivenNonEmptyEnumerable()
        {
            Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(new[] { "foo", "bar" }, "stringArray");
            Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(new[] { 1, 2 }, "intArray");
        }

        [Fact]
        public void ThrowsGivenNullString()
        {
            string? nullString = null;
            Assert.Throws<ArgumentNullException>(() =>
                Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(nullString, "nullString"));
        }

        [Fact]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty("", "emptyString"));
        }

        [Fact]
        public void ThrowsGivenNullGuid()
        {
            Guid? nullGuid = null;
            Assert.Throws<ArgumentNullException>(() =>
                Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(nullGuid, "nullGuid"));
        }

        [Fact]
        public void ThrowsGivenEmptyGuid()
        {
            Assert.Throws<ArgumentException>(
                () => Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(Guid.Empty, "emptyGuid"));
        }

        [Fact]
        public void ThrowsGivenEmptyEnumerable()
        {
            Assert.Throws<ArgumentException>(() =>
                Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(Enumerable.Empty<string>(), "emptyStringEnumerable"));
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenValidValue()
        {
            Assert.Equal("a", Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty("a", "string"));
            Assert.Equal("1", Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty("1", "aNumericString"));

            var collection1 = new[] { "foo", "bar" };
            Assert.Equal(collection1, Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(collection1, "stringArray"));

            var collection2 = new[] { 1, 2 };
            Assert.Equal(collection2, Cactus.Blade.Guard.Guard.MustBe.NullOrEmpty(collection2, "intArray"));
        }
    }
}
