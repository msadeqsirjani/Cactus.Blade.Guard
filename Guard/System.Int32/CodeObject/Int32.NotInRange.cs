using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard NotInRange(this IGuard _, int value, int minimum, int maximum)
    {
        return Guard.MustBe.NotInRange(value, null, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard _, int value, string paramName, int minimum, int maximum)
    {
        return Guard.MustBe.NotInRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard _, int value, string paramName, string message, int minimum, int maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.NotInRange(value, minimum, maximum);

        if (value.NotInRange(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}