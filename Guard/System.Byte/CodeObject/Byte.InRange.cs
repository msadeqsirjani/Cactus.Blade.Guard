using Cactus.Blade.Guard;
using Cactus.Blade.Guard.Common;
using System;

public static partial class GuardExtension
{
    public static byte InRange(this IGuard _, byte value, byte minimum, byte maximum)
    {
        return Guard.Against.InRange(value, null, null, minimum, maximum);
    }

    public static byte InRange(this IGuard _, byte value, string paramName, byte minimum, byte maximum)
    {
        return Guard.Against.InRange(value, paramName, null, minimum, maximum);
    }

    public static byte InRange(this IGuard _, byte value, string paramName, string message, byte minimum, byte maximum)
    {
        paramName ??= nameof(value);
        message ??= Message.InRange(value, minimum, maximum);

        if (value.InRange(minimum, maximum)) return value;

        throw new ArgumentOutOfRangeException(message, paramName);
    }
}