using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, DateTimeOffset input)
    {
        return Guard.MustBe.NotDefault<DateTimeOffset>(input);
    }

    public static IGuard NotDefault(this IGuard _, DateTimeOffset input, string paramName)
    {
        return Guard.MustBe.NotDefault<DateTimeOffset>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<DateTimeOffset>(input, paramName, message);
    }
}