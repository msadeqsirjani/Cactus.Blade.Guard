using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input)
    {
        return Guard.Against.Default(input, null, null);
    }

    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input, string paramName)
    {
        return Guard.Against.Default(input, paramName, null);
    }

    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.Against.Default<DateTimeOffset>(input, paramName, message);
    }
}