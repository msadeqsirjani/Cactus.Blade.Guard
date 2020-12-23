using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static long Between(this IGuard _, long value, long minimum, long maximum)
    {
        return Guard.Against.Between(value, null, null, minimum, maximum);
    }

    public static long Between(this IGuard _, long value, string paramName, long minimum, long maximum)
    {
        return Guard.Against.Between(value, paramName, null, minimum, maximum);
    }

    public static long Between(this IGuard _, long value, string paramName, string message, long minimum, long maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}