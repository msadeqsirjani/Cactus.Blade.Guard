using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static uint InRange(this IGuard _, uint value, uint minimum, uint maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static uint InRange(this IGuard _, uint value, string paramName, uint minimum, uint maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static uint InRange(this IGuard _, uint value, string paramName, string message, uint minimum, uint maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}