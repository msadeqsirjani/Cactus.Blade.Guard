using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static short InRange(this IGuard _, short value, short minimum, short maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static short InRange(this IGuard _, short value, string paramName, short minimum, short maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static short InRange(this IGuard _, short value, string paramName, string message, short minimum, short maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}