using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static decimal InRange(this IGuard _, decimal value, decimal minimum, decimal maximum)
    {
        return Guard.MustBe.InRange(value, null, null, minimum, maximum);
    }

    public static decimal InRange(this IGuard _, decimal value, string paramName, decimal minimum, decimal maximum)
    {
        return Guard.MustBe.InRange(value, paramName, null, minimum, maximum);
    }

    public static decimal InRange(this IGuard _, decimal value, string paramName, string message, decimal minimum, decimal maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}