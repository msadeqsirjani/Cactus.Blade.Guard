using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static DateTime Default(this IGuard _, DateTime input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static DateTime Default(this IGuard _, DateTime input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static DateTime Default(this IGuard _, DateTime input, string paramName, string message)
    {
        return Guard.Against.Default<DateTime>(input, paramName, message);
    }
}