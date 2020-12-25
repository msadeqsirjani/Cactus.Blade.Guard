using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static IGuard InRange(this IGuard _, ushort value, ushort minimum, ushort maximum)
    {
        return Guard.MustBe.InRange(value, null, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard _, ushort value, string paramName, ushort minimum, ushort maximum)
    {
        return Guard.MustBe.InRange(value, paramName, null, minimum, maximum);
    }

    public static IGuard InRange(this IGuard _, ushort value, string paramName, string message, ushort minimum, ushort maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return _;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}