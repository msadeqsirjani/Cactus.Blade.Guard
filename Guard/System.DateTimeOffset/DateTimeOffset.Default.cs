using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, DateTimeOffset input)
    {
        return Guard.MustBe.Default<DateTimeOffset>(input);
    }

    public static IGuard Default(this IGuard _, DateTimeOffset input, string paramName)
    {
        return Guard.MustBe.Default<DateTimeOffset>(input, paramName);
    }

    public static IGuard Default(this IGuard _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.MustBe.Default<DateTimeOffset>(input, paramName, message);
    }
}