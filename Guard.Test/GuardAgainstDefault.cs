using Cactus.Blade.Guard;
using System;
using System.Collections.Generic;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstDefault
    {
        [Fact]
        public void DoesNothingGivenNonDefaultValue()
        {
            Cactus.Blade.Guard.Guard.Against.Default("", "string");
            Cactus.Blade.Guard.Guard.Against.Default(1, "int");
            Cactus.Blade.Guard.Guard.Against.Default(Guid.NewGuid(), "guid");
            Cactus.Blade.Guard.Guard.Against.Default(DateTime.Now, "datetime");
            Cactus.Blade.Guard.Guard.Against.Default(new object(), "object");
        }

        [Fact]
        public void ThrowsGivenDefaultValue()
        {
            Assert.Throws<ArgumentException>("string", () => Cactus.Blade.Guard.Guard.Against.Default(default(string), "string"));
            Assert.Throws<ArgumentException>("int", () => Cactus.Blade.Guard.Guard.Against.Default(default(int), "int"));
            Assert.Throws<ArgumentException>("guid", () => Cactus.Blade.Guard.Guard.Against.Default(default(Guid), "guid"));
            Assert.Throws<ArgumentException>("datetime", () => Cactus.Blade.Guard.Guard.Against.Default(default(DateTime), "datetime"));
            Assert.Throws<ArgumentException>("object", () => Cactus.Blade.Guard.Guard.Against.Default(default(object), "object"));
        }

        [Theory]
        [MemberData(nameof(GetNonDefaultTestVectors))]
        public void ReturnsExpectedValueWhenGivenNonDefaultValue(object input, string name, object expected)
        {
            var actual = Cactus.Blade.Guard.Guard.Against.Default(input, name);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetNonDefaultTestVectors()
        {
            yield return new object[] { "", "string", "" };
            yield return new object[] { 1, "int", 1 };

            var guid = Guid.NewGuid();
            yield return new object[] { guid, "guid", guid };

            var now = DateTime.Now;
            yield return new object[] { now, "now", now };

            var obj = new Object();
            yield return new object[] { obj, "obj", obj };
        }
    }
}
