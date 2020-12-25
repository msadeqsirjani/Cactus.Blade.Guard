using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Min(DateTimeOffset input, DateTimeOffset minimum)
    {
        return Guard.MustBe.Min(input, minimum);
    }

    public static IGuard Min(DateTimeOffset input, DateTimeOffset minimum, string paramName)
    {
        return Guard.MustBe.Min(input, minimum, paramName);
    }

    public static IGuard Min(DateTimeOffset input, DateTimeOffset minimum, string paramName, string message)
    {
        return Guard.MustBe.Min(input, minimum, paramName, message);
    }
}