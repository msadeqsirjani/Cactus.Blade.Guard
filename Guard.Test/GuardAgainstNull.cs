using Cactus.Blade.Guard;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeNull
    {
        [Fact]
        public void DoesNothingGivenNonNullValue()
        {
            Cactus.Blade.Guard.Guard.MustBe.Null("", "string");
            Cactus.Blade.Guard.Guard.MustBe.Null(1, "int");
            Cactus.Blade.Guard.Guard.MustBe.Null(Guid.Empty, "guid");
            Cactus.Blade.Guard.Guard.MustBe.Null(DateTime.Now, "datetime");
            Cactus.Blade.Guard.Guard.MustBe.Null(new object(), "object");
        }

        [Fact]
        public void ThrowsGivenNullValue()
        {
            object obj = null!;
            Assert.Throws<ArgumentNullException>(() => Cactus.Blade.Guard.Guard.MustBe.Null(obj, "null"));
        }

        [Fact]
        public void ReturnsExpectedValueWhenGivenNonNullValue()
        {
            Assert.Equal("", Cactus.Blade.Guard.Guard.MustBe.Null("", "string"));
            Assert.Equal(1, Cactus.Blade.Guard.Guard.MustBe.Null(1, "int"));

            var guid = Guid.Empty;
            Assert.Equal(guid, Cactus.Blade.Guard.Guard.MustBe.Null(guid, "guid"));

            var now = DateTime.Now;
            Assert.Equal(now, Cactus.Blade.Guard.Guard.MustBe.Null(now, "datetime"));

            var obj = new object();
            Assert.Equal(obj, Cactus.Blade.Guard.Guard.MustBe.Null(obj, "object"));
        }
    }
}
