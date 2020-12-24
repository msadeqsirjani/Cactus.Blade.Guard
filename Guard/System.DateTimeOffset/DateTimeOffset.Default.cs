using Cactus.Blade.Guard;
using System;

public static partial class GuardExtension
{
    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input)
    {
        return Guard.MustBe.Default(input, null, null);
    }

    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input, string paramName)
    {
        return Guard.MustBe.Default(input, paramName, null);
    }

    public static DateTimeOffset Default(this IGuard _, DateTimeOffset input, string paramName, string message)
    {
        return Guard.MustBe.Default<DateTimeOffset>(input, paramName, message);
    }
}