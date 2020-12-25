using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard Default(this IGuard _, DateTime input)
    {
        return Guard.MustBe.Default<DateTime>(input);
    }

    public static IGuard Default(this IGuard _, DateTime input, string paramName)
    {
        return Guard.MustBe.Default<DateTime>(input, paramName);
    }

    public static IGuard Default(this IGuard _, DateTime input, string paramName, string message)
    {
        return Guard.MustBe.Default<DateTime>(input, paramName, message);
    }
}