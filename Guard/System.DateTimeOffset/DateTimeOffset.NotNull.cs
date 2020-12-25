using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotNull(DateTimeOffset? input)
    {
        return Guard.MustBe.NotNull(input, null, null);
    }

    public static IGuard NotNull(DateTimeOffset? input, string paramName)
    {
        return Guard.MustBe.NotNull(input, paramName, null);
    }

    public static IGuard NotNull(DateTimeOffset? input, string paramName, string message)
    {
        return Guard.MustBe.NotNull(input, paramName, message);
    }
}