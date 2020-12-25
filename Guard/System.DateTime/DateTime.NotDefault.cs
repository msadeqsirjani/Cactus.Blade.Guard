using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static IGuard NotDefault(this IGuard _, DateTime input)
    {
        return Guard.MustBe.NotDefault<DateTime>(input);
    }

    public static IGuard NotDefault(this IGuard _, DateTime input, string paramName)
    {
        return Guard.MustBe.NotDefault<DateTime>(input, paramName);
    }

    public static IGuard NotDefault(this IGuard _, DateTime input, string paramName, string message)
    {
        return Guard.MustBe.NotDefault<DateTime>(input, paramName, message);
    }
}