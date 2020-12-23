using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static ulong InRange(this IGuard _, ulong value, ulong minimum, ulong maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static ulong InRange(this IGuard _, ulong value, string paramName, ulong minimum, ulong maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static ulong InRange(this IGuard _, ulong value, string paramName, string message, ulong minimum, ulong maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}