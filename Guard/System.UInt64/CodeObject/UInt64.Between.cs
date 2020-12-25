using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard Between(this IGuard _, ulong value, ulong minimum, ulong maximum)
    {
        return Guard.MustBe.Between(value, null, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, ulong value, string paramName, ulong minimum, ulong maximum)
    {
        return Guard.MustBe.Between(value, paramName, null, minimum, maximum);
    }

    public static IGuard Between(this IGuard _, ulong value, string paramName, string message, ulong minimum, ulong maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.Between(value, minimum, maximum);

        if (value.Between(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}