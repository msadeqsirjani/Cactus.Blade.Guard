using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstNull
    {
        [Fact]
        public void DoesNothingGivenNonNullValue()
        {
            Cactus.Blade.Guard.Guard.Against.Null("", "string");
            Cactus.Blade.Guard.Guard.Against.Null(1, "int");
            Cactus.Blade.Guard.Guard.Against.Null(Guid.Empty, "guid");
            Cactus.Blade.Guard.Guard.Against.Null(DateTime.Now, "datetime");
            Cactus.Blade.Guard.Guard.Against.Null(new object(), "object");
        }

        [Fact]
        public void ThrowsGivenNullValue()
        {
            object obj = null!;
            Assert.Throws<ArgumentNullException>(() => Cactus.Blade.Guard.Guard.Against.Null(obj, "null"));
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenNonNullValue()
        {
            Assert.Equal("", Cactus.Blade.Guard.Guard.Against.Null("", "string"));
            Assert.Equal(1, Cactus.Blade.Guard.Guard.Against.Null(1, "int"));

            var guid = Guid.Empty;
            Assert.Equal(guid, Cactus.Blade.Guard.Guard.Against.Null(guid, "guid"));

            var now = DateTime.Now;
            Assert.Equal(now, Cactus.Blade.Guard.Guard.Against.Null(now, "datetime"));

            var obj = new object();
            Assert.Equal(obj, Cactus.Blade.Guard.Guard.Against.Null(obj, "object"));
        }
    }
}
