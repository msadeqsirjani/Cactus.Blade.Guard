using Guard.Test.NamespaceSeparate;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstFooExtension
    {
        [Fact]
        public void ThrowsGivenFoo()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.Against.Foo("foo", "aParameterName"));
        }

        [Fact]
        public void DoesNothingGivenAnythingElse()
        {
            Cactus.Blade.Guard.Guard.Against.Foo("anythingElse", "aParameterName");
        }
    }
}
