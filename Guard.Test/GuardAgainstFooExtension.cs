using Guard.Test.NamespaceSeparate;
using System;
using Xunit;

namespace Guard.Test
{
    public class GuardMustBeFooExtension
    {
        [Fact]
        public void ThrowsGivenFoo()
        {
            Assert.Throws<ArgumentException>(() => Cactus.Blade.Guard.Guard.MustBe.Foo("foo", "aParameterName"));
        }

        [Fact]
        public void DoesNothingGivenAnythingElse()
        {
            Cactus.Blade.Guard.Guard.MustBe.Foo("anythingElse", "aParameterName");
        }
    }
}
