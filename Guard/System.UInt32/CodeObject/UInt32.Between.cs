using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static uint Between(this IGuard _, uint value, uint minimum, uint maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static uint Between(this IGuard _, uint value, string paramName, uint minimum, uint maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static uint Between(this IGuard _, uint value, string paramName, string message, uint minimum, uint maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}