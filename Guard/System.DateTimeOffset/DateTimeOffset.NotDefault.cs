using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, DateTimeOffset input)
    {
        return Guard.MustBe.NotDefault(input, null, null);
    }

    public static IGuard NotDefault(this IGuard _, DateTimeOffset input, string paramName)
    {
        return Guard.MustBe.NotDefault(input, paramName, null);
    }

    public static IGuard NotDefault(this IGuard _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<DateTimeOffset>(input, paramName, message);
    }
}