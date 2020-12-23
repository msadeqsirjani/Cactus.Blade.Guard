using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static int Between(this IGuard _, int value, int minimum, int maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static int Between(this IGuard _, int value, string paramName, int minimum, int maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static int Between(this IGuard _, int value, string paramName, string message, int minimum, int maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}