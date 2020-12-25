using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Max(DateTimeOffset input, DateTimeOffset minimum)
    {
        return Guard.MustBe.Max(input, minimum);
    }

    public static IGuard Max(DateTimeOffset input, DateTimeOffset minimum, string paramName)
    {
        return Guard.MustBe.Max(input, minimum, paramName);
    }

    public static IGuard Max(DateTimeOffset input, DateTimeOffset minimum, string paramName, string message)
    {
        return Guard.MustBe.Max(input, minimum, paramName, message);
    }
}