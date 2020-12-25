using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard NotInRange(this IGuard _, uint value, uint minimum, uint maximum)
    {
        return Guard.MustBe.NotInRange(value, null, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard _, uint value, string paramName, uint minimum, uint maximum)
    {
        return Guard.MustBe.NotInRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard NotInRange(this IGuard _, uint value, string paramName, string message, uint minimum, uint maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.NotInRange(value, minimum, maximum);

        if (value.NotInRange(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}