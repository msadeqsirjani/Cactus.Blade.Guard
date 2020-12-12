using Cactus.Blade.Guard;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Xunit;

namespace Guard.Test
{
    public class GuardAgainstOutOfSqlDateRange
    {
        [Theory]
        [InlineData(1)]
        [InlineData(60)]
        [InlineData(60 * 60)]
        [InlineData(60 * 60 * 24)]
        [InlineData(60 * 60 * 24 * 30)]
        [InlineData(60 * 60 * 24 * 30 * 365)]
        public void ThrowsGivenValueBelowMinDate(int offsetInSeconds)
        {
            var date = SqlDateTime.MinValue.Value.AddSeconds(-offsetInSeconds);

            Assert.Throws<ArgumentOutOfRangeException>(() => Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(date, nameof(date)));
        }

        [Fact]
        public void DoNothingGivenCurrentDate()
        {
            Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(DateTime.Today, "Today");
            Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(DateTime.Now, "Now");
            Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(DateTime.UtcNow, "UTC Now");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(60)]
        [InlineData(60 * 60)]
        [InlineData(60 * 60 * 24)]
        [InlineData(60 * 60 * 24 * 30)]
        [InlineData(60 * 60 * 24 * 30 * 365)]
        public void DoNothingGivenSqlMinValue(int offsetInSeconds)
        {
            var date = SqlDateTime.MinValue.Value.AddSeconds(offsetInSeconds);

            Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(date, nameof(date));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(60)]
        [InlineData(60 * 60)]
        [InlineData(60 * 60 * 24)]
        [InlineData(60 * 60 * 24 * 30)]
        [InlineData(60 * 60 * 24 * 30 * 365)]
        public void DoNothingGivenSqlMaxValue(int offsetInSeconds)
        {
            var date = SqlDateTime.MaxValue.Value.AddSeconds(-offsetInSeconds);

            Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(date, nameof(date));
        }

        [Theory]
        [MemberData(nameof(GetSqlDateTimeTestVectors))]
        public void ReturnsExpectedValueWhenGivenValidSqlDateTime(DateTime input, string name, DateTime expected)
        {
            Assert.Equal(expected, Cactus.Blade.Guard.Guard.Against.OutOfSqlDateRange(input, name));
        }

        public static IEnumerable<object[]> GetSqlDateTimeTestVectors()
        {
            var now = DateTime.Now;
            var utc = DateTime.UtcNow;
            var yesterday = DateTime.Now.AddDays(-1);
            var min = SqlDateTime.MinValue.Value;
            var max = SqlDateTime.MaxValue.Value;

            yield return new object[] { now, "now", now };
            yield return new object[] { utc, "utc", utc };
            yield return new object[] { yesterday, "yesterday", yesterday };
            yield return new object[] { min, "min", min };
            yield return new object[] { max, "max", max };
        }
    }
}
