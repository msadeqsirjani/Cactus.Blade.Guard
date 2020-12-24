using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static DateTime Default(this IGuard _, DateTime input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static DateTime Default(this IGuard _, DateTime input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static DateTime Default(this IGuard _, DateTime input, string paramName, string message)
    {
        return Guard.MustBe.Default<DateTime>(input, paramName, message);
    }
}