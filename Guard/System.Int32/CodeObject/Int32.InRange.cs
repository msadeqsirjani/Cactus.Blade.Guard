using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static int InRange(this IGuard _, int value, int minimum, int maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static int InRange(this IGuard _, int value, string paramName, int minimum, int maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static int InRange(this IGuard _, int value, string paramName, string message, int minimum, int maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}