using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard Between(this IGuard _, int value, int minimum, int maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, int value, string paramName, int minimum, int maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, int value, string paramName, string message, int minimum, int maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}